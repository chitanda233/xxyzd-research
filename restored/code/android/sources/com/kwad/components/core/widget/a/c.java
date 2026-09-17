package com.kwad.components.core.widget.a;

import android.view.View;
import com.kwad.sdk.utils.cb;

/* JADX INFO: loaded from: classes3.dex */
public class c extends a {
    private View mRootView;

    public c(View view, int i) {
        super(view, i);
        this.mRootView = view;
    }

    @Override // com.kwad.components.core.widget.a.a
    public boolean ah() {
        return cb.a(this.mRootView, 70, true);
    }
}
