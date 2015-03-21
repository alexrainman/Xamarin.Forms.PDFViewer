package com.radaee.util;

import java.io.File;
import java.util.Vector;


import android.content.Context;
import android.os.Handler;
import android.os.Message;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;

public class PDFGridAdt extends BaseAdapter
{
	private Context m_context;
	private Handler m_hand_ui = new Handler()
	{
		public void handleMessage(Message msg)
		{
			PDFGridItem item = (PDFGridItem)msg.obj;
			item.page_set();
			notifyDataSetChanged();
			super.handleMessage(msg);
		}
	};
	private PDFGridThread m_thread;
	static protected int clr_back = 0xFFCCCCCC;
	static protected int clr_text = 0xFF000044;
	public class SnatchItem
	{
		public String m_path;
		public String m_name;
		public PDFGridItem m_item;
	}
	private Vector<SnatchItem> m_items = new Vector<SnatchItem>();
	private void insert_item( SnatchItem item )
	{
		int left = 0;
		int right = m_items.size() - 1;
		if( item.m_item.is_dir() )
		{
			while( left <= right )
			{
				int mid = (left + right)>>1;
				SnatchItem tmp = m_items.get(mid);
				if( !tmp.m_item.is_dir() )
					right = mid - 1;
				else
				{
					int ret = item.m_name.compareToIgnoreCase(tmp.m_name);
					if( ret == 0 )
					{
						left = mid;
						break;
					}
					if( ret > 0 ) left = mid + 1;
					else right = mid - 1;
				}
			}
		}
		else
		{
			while( left <= right )
			{
				int mid = (left + right)>>1;
				SnatchItem tmp = m_items.get(mid);
				if( tmp.m_item.is_dir() )
					left = mid + 1;
				else
				{
					int ret = item.m_name.compareToIgnoreCase(tmp.m_name);
					if( ret == 0 )
					{
						left = mid;
						break;
					}
					if( ret > 0 ) left = mid + 1;
					else right = mid - 1;
				}
			}
		}
		m_items.insertElementAt(item, left);
	}
	public void destroy()
	{
		int cur = 0;
		int cnt = m_items.size();
		while( cur < cnt )
		{
			m_items.get(cur).m_item.page_destroy();
			cur++;
		}
		m_thread.destroy();
		m_items.clear();
	}
	public void set_dir( File file, boolean need_up )
	{
		int cur = 0;
		int cnt = m_items.size();
		while( cur < cnt )
		{
			m_items.get(cur).m_item.page_destroy();
			cur++;
		}
		m_items.clear();
		{
			SnatchItem item = new SnatchItem();
			item.m_name = ".";
			item.m_path = null;
			item.m_item = new PDFGridItem(m_context, null);
			item.m_item.set_dir(item.m_name, item.m_path);
			insert_item( item );
		}
		if( need_up )
		{
			SnatchItem item = new SnatchItem();
			item.m_name = "..";
			item.m_path = null;
			item.m_item = new PDFGridItem(m_context, null);
			item.m_item.set_dir(item.m_name, item.m_path);
			insert_item( item );
		}

		File files[] = file.listFiles();
		if( files == null )
		{
			notifyDataSetChanged();
			return;
		}
		cur = 0;
		cnt = files.length;
		while( cur < cnt )
		{
			if( !files[cur].isHidden() )
			{
				if( files[cur].isFile() )
				{
					String name = files[cur].getName();
					int len = name.length();
					if( len > 4 )
					{
						String ext = name.substring(name.length() - 4);
						if( ext.compareToIgnoreCase(".pdf") == 0 )
						{
							SnatchItem item = new SnatchItem();
							item.m_name = files[cur].getName();
							item.m_path = files[cur].getPath();
							item.m_item = new PDFGridItem(m_context, null);
							item.m_item.set_file(m_thread, item.m_name, item.m_path);
							insert_item( item );
						}
					}
				}
				if( files[cur].isDirectory() )
				{
					SnatchItem item = new SnatchItem();
					item.m_name = files[cur].getName();
					item.m_path = files[cur].getPath();
					item.m_item = new PDFGridItem(m_context, null);
					item.m_item.set_dir(item.m_name, item.m_path);
					insert_item( item );
				}
			}
			cur++;
		}
		notifyDataSetChanged();
	}
	public PDFGridAdt( Context ctx )
	{
		m_context = ctx;
		m_thread = new PDFGridThread( m_hand_ui );
		m_thread.start();
	}
	public int getCount()
	{
		return m_items.size();
	}

	public Object getItem(int arg0)
	{
		return m_items.get(arg0);
	}

	public long getItemId(int position)
	{
		return 0;
	}

	public View getView(int position, View convertView, ViewGroup parent)
	{
		return m_items.get(position).m_item;
	}

}
