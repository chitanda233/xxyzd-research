package com.baidu.oauth.sdkbqt.view;

import android.view.View;
import android.widget.AdapterView;

/* JADX INFO: loaded from: classes.dex */
class h implements AdapterView.OnItemClickListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ g f608a;

    h(g gVar) {
        this.f608a = gVar;
    }

    @Override // android.widget.AdapterView.OnItemClickListener
    public void onItemClick(AdapterView<?> adapterView, View view, int i, long j) {
        g.a item = this.f608a.b.getItem(i);
        item.c.a(item);
    }
}
