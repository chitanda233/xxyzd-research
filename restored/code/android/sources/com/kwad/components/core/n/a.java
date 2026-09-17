package com.kwad.components.core.n;

import android.app.Activity;
import android.content.Context;
import android.view.View;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.mvp.a {
    public List<com.kwad.components.core.n.a.a> abs = new ArrayList();
    private final b<?> abt;
    public final Context mContext;
    public final View mRootView;

    public a(b<?> bVar) {
        this.abt = bVar;
        this.mContext = bVar.mContext;
        this.mRootView = bVar.mRootView;
    }

    @Override // com.kwad.sdk.mvp.a
    public void release() {
        this.abs.clear();
    }

    public final void iK() {
        this.abt.finish();
    }

    @Deprecated
    public final Activity getActivity() {
        return this.abt.getActivity();
    }
}
