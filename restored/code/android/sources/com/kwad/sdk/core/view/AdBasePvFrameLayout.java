package com.kwad.sdk.core.view;

import android.content.Context;
import android.util.AttributeSet;
import android.view.ViewTreeObserver;
import com.kwad.sdk.utils.ca;
import com.kwad.sdk.utils.n;
import com.kwad.sdk.widget.l;

/* JADX INFO: loaded from: classes3.dex */
public class AdBasePvFrameLayout extends AdBaseFrameLayout {
    private long alE;
    private float baM;
    private boolean baN;
    private boolean baO;
    private ViewTreeObserver.OnScrollChangedListener baP;
    private ca baQ;
    private l eR;
    private int oY;
    private ViewTreeObserver qv;

    public AdBasePvFrameLayout(Context context) {
        super(context);
        this.alE = 500L;
        this.baM = 0.1f;
        this.baO = true;
        init();
    }

    public AdBasePvFrameLayout(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.alE = 500L;
        this.baM = 0.1f;
        this.baO = true;
        init();
    }

    public AdBasePvFrameLayout(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.alE = 500L;
        this.baM = 0.1f;
        this.baO = true;
        init();
    }

    private void init() {
        this.baQ = new ca(this);
        this.oY = n.getScreenHeight(getContext());
        this.baO = true;
    }

    @Override // android.view.View
    protected void onSizeChanged(int i, int i2, int i3, int i4) {
        boolean z;
        if (this.baN || (i3 | i4) != 0 || (i | i2) == 0) {
            z = false;
        } else {
            z = true;
            this.baN = true;
        }
        super.onSizeChanged(i, i2, i3, i4);
        if (z) {
            qY();
        }
    }

    private void qY() {
        if (this.baO) {
            Px();
        }
    }

    private void Px() {
        if (Pz()) {
            Py();
        } else {
            PA();
        }
    }

    protected final void Py() {
        PB();
        l lVar = this.eR;
        if (lVar != null) {
            lVar.aV();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean Pz() {
        return this.baQ.Xq() && ((float) Math.abs(this.baQ.brv.height() - getHeight())) <= ((float) getHeight()) * (1.0f - this.baM) && getHeight() > 0 && getWidth() > 0 && this.baQ.brv.bottom > 0 && this.baQ.brv.top < this.oY;
    }

    public void setCheckDefaultImpressionLogThreshold(float f) {
        this.baM = f;
    }

    private void PA() {
        if (this.baP == null) {
            this.baP = new ViewTreeObserver.OnScrollChangedListener() { // from class: com.kwad.sdk.core.view.AdBasePvFrameLayout.1
                @Override // android.view.ViewTreeObserver.OnScrollChangedListener
                public final void onScrollChanged() {
                    if (AdBasePvFrameLayout.this.Pz()) {
                        AdBasePvFrameLayout.this.Py();
                    }
                }
            };
            ViewTreeObserver viewTreeObserver = getViewTreeObserver();
            this.qv = viewTreeObserver;
            if (viewTreeObserver != null) {
                viewTreeObserver.addOnScrollChangedListener(this.baP);
            }
        }
    }

    private void PB() {
        ViewTreeObserver viewTreeObserver;
        try {
            if (this.baP != null && (viewTreeObserver = this.qv) != null && viewTreeObserver.isAlive()) {
                this.qv.removeOnScrollChangedListener(this.baP);
            }
            this.baP = null;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        PB();
        this.baN = false;
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();
        PA();
    }

    public void setVisibleListener(l lVar) {
        this.eR = lVar;
    }
}
