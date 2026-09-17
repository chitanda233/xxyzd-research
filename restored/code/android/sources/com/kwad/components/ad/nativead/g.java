package com.kwad.components.ad.nativead;

import android.view.View;
import com.kwad.sdk.utils.cb;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.components.core.widget.a.c {
    private final View mRootView;

    public g(View view) {
        this(view, fB());
    }

    private g(View view, int i) {
        super(view, i);
        this.mRootView = view;
    }

    private static int fB() {
        try {
            int iKo = ((int) com.kwad.sdk.core.config.e.Ko()) * 100;
            if (iKo < 0 || iKo > 100) {
                return 30;
            }
            return iKo;
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.components.core.widget.a.c, com.kwad.components.core.widget.a.a
    public final boolean ah() {
        return cb.a(this.mRootView, fB(), true);
    }
}
