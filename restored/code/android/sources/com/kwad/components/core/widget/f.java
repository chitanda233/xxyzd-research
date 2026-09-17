package com.kwad.components.core.widget;

import android.content.Context;
import android.content.res.Configuration;
import android.widget.FrameLayout;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends FrameLayout {
    private boolean awA;
    protected boolean lE;
    protected g ll;
    protected Context mContext;

    public f(Context context) {
        super(context);
        this.mContext = context;
        this.lE = as.VV();
    }

    public final void setOrientationChangeListener(g gVar) {
        this.ll = gVar;
    }

    @Override // android.view.View
    protected final void onWindowVisibilityChanged(int i) {
        super.onWindowVisibilityChanged(i);
        this.awA = i == 0;
        Ak();
    }

    @Override // android.view.View
    protected final void onConfigurationChanged(Configuration configuration) {
        super.onConfigurationChanged(configuration);
        Ak();
    }

    private void Ak() {
        boolean zVV = as.VV();
        if (!this.awA || zVV == this.lE) {
            return;
        }
        this.lE = zVV;
        g gVar = this.ll;
        if (gVar != null) {
            gVar.k(!zVV);
        }
    }
}
