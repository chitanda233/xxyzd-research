package com.kwad.components.core.innerEc.live.i;

import android.view.View;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements View.OnClickListener {
    private final View.OnClickListener XR;
    private long ws = 0;

    public b(View.OnClickListener onClickListener) {
        this.XR = onClickListener;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        try {
            if (System.currentTimeMillis() - this.ws >= 500) {
                this.XR.onClick(view);
                this.ws = System.currentTimeMillis();
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
