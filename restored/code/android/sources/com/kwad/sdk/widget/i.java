package com.kwad.sdk.widget;

import android.view.View;
import android.view.ViewTreeObserver;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ca;
import com.kwad.sdk.utils.n;

/* JADX INFO: loaded from: classes3.dex */
public final class i {
    private final ca baQ;
    private ViewTreeObserver.OnScrollChangedListener btB;
    private final k btw;
    private boolean bty;
    private boolean btz;
    private final View mView;
    private final int oY;
    private float btx = 0.1f;
    private boolean btA = true;

    public i(View view, k kVar) {
        this.mView = view;
        this.btw = kVar;
        this.baQ = new ca(view);
        this.oY = n.getScreenHeight(view.getContext());
    }

    public final void cG(boolean z) {
        this.btA = z;
    }

    public final void setVisiblePercent(float f) {
        this.btx = f;
    }

    public final float getVisiblePercent() {
        return this.btx;
    }

    public final void d(int i, int i2, int i3, int i4) {
        this.btz = false;
        if (this.bty || (i3 | i4) != 0 || (i | i2) == 0) {
            return;
        }
        this.btz = true;
        this.bty = true;
    }

    public final void XS() {
        if (this.btz) {
            qY();
        }
    }

    public final void onAttachedToWindow() {
        PA();
    }

    public final void onDetachedFromWindow() {
        PB();
        this.bty = false;
    }

    private void qY() {
        if (this.btA) {
            XT();
        }
    }

    private void XT() {
        if (XU()) {
            aV();
        } else {
            PB();
            PA();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aV() {
        try {
            PB();
            k kVar = this.btw;
            if (kVar != null) {
                kVar.H(this.mView);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean XU() {
        return this.baQ.Xq() && ((float) Math.abs(this.baQ.brv.height() - this.mView.getHeight())) <= ((float) this.mView.getHeight()) * (1.0f - this.btx) && this.mView.getHeight() > 0 && this.mView.getWidth() > 0 && this.baQ.brv.bottom > 0 && this.baQ.brv.top < this.oY;
    }

    private void PA() {
        if (this.btB == null) {
            this.btB = new ViewTreeObserver.OnScrollChangedListener() { // from class: com.kwad.sdk.widget.i.1
                @Override // android.view.ViewTreeObserver.OnScrollChangedListener
                public final void onScrollChanged() {
                    if (i.this.XU()) {
                        i.this.aV();
                    }
                }
            };
            ViewTreeObserver viewTreeObserver = this.mView.getViewTreeObserver();
            if (viewTreeObserver != null) {
                viewTreeObserver.addOnScrollChangedListener(this.btB);
            }
        }
    }

    private void PB() {
        if (this.btB == null) {
            return;
        }
        try {
            ViewTreeObserver viewTreeObserver = this.mView.getViewTreeObserver();
            if (viewTreeObserver != null) {
                viewTreeObserver.removeOnScrollChangedListener(this.btB);
            }
            this.btB = null;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }
}
