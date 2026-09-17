package com.kwad.components.ad.draw;

import android.view.View;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.utils.cb;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.core.widget.a.c {
    private View mRootView;

    public b(View view) {
        super(view, aI());
        this.mRootView = view;
    }

    @Override // com.kwad.components.core.widget.a.c, com.kwad.components.core.widget.a.a
    public final boolean ah() {
        return cb.a(this.mRootView, aI(), true);
    }

    private static int aI() {
        try {
            int iKp = ((int) e.Kp()) * 100;
            if (iKp < 0 || iKp > 100) {
                return 70;
            }
            return iKp;
        } catch (Throwable unused) {
        }
    }
}
