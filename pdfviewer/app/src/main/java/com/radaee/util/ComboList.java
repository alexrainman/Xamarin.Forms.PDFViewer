package com.radaee.util;

import android.content.Context;
import android.util.AttributeSet;
import android.widget.ListView;

public class ComboList extends ListView
{
	ComboListAdt m_adt;
	public ComboList(Context context, AttributeSet attrs)
	{
		super(context, attrs);
		m_adt = new ComboListAdt();
	}
	public void set_opts(String[] opts)
	{
		setAdapter(m_adt);
		m_adt.set_opts(opts);
		this.setBackgroundColor(ComboListAdt.back_color);
	}
}
