package com.radaee.util;

import android.content.Context;
import android.util.AttributeSet;
import android.widget.ExpandableListView;

public class SnatchView extends ExpandableListView
{
	SnatchAdt m_adt;
	public SnatchView(Context context)
	{
		super(context);
		m_adt = new SnatchAdt(context);
	}

	public SnatchView(Context context, AttributeSet attrs)
	{
		super(context);
		m_adt = new SnatchAdt(context);
	}
	public void start()
	{
		setAdapter(m_adt);
		m_adt.start();
		setBackgroundColor(SnatchAdt.clr_back);
	}
	public String getChildPath(int group, int child)
	{
		return m_adt.getChildPath(group, child);
	}
	public void close()
	{
		m_adt.close();
	}
}
