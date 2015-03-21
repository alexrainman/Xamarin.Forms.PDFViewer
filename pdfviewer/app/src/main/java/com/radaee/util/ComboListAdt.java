package com.radaee.util;

import android.database.DataSetObserver;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListAdapter;
import android.widget.TextView;


public class ComboListAdt implements ListAdapter
{
	private DataSetObserver m_obs = null;
	private String m_opts[] = null;
	protected static int back_color = 0xFFFFFFC0;
	public void set_opts( String[] opts )
	{
		m_opts = opts;
		m_obs.onChanged();
	}
	public int getCount()
	{
		if( m_opts == null ) return 0;
		return m_opts.length;
	}

	public Object getItem(int arg0)
	{
		return m_opts[arg0];
	}

	public long getItemId(int position)
	{
		return 0;
	}

	public int getItemViewType(int position)
	{
		return 0;
	}

	public View getView(int position, View convertView, ViewGroup parent)
	{
		TextView v = new TextView(parent.getContext());
		v.setText(m_opts[position]);
		v.setTextColor(0xFF000000);
		v.setBackgroundColor(0xFFFFFFC0);
		return v;
	}

	public int getViewTypeCount()
	{
		return 1;
	}

	public boolean hasStableIds()
	{
		return false;
	}

	public boolean isEmpty()
	{
		return (m_opts == null) || (m_opts.length > 0);
	}

	public void registerDataSetObserver(DataSetObserver observer)
	{
		m_obs = observer;
	}

	public void unregisterDataSetObserver(DataSetObserver observer)
	{
		m_obs = null;
	}

	public boolean areAllItemsEnabled()
	{
		return true;
	}

	public boolean isEnabled(int position)
	{
		return true;
	}
}
