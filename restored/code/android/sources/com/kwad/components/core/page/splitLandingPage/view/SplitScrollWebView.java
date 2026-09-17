package com.kwad.components.core.page.splitLandingPage.view;

import android.app.Activity;
import android.content.Context;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;
import androidx.core.view.MotionEventCompat;
import com.kwad.components.core.t.d;
import com.kwad.sdk.core.webview.KsAdWebView;

/* JADX INFO: loaded from: classes3.dex */
public class SplitScrollWebView extends KsAdWebView {
    private boolean afR;
    private a afS;
    private float afT;
    private boolean afU;
    private int aft;

    public interface a {
        void g(float f);

        boolean vd();
    }

    public SplitScrollWebView(Context context) {
        super(context);
        this.afR = false;
        uX();
    }

    public SplitScrollWebView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.afR = false;
        uX();
    }

    public SplitScrollWebView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.afR = false;
        uX();
    }

    public void setDisableAnimation(boolean z) {
        this.afR = z;
    }

    public void setSplitScrollWebViewListener(a aVar) {
        this.afS = aVar;
    }

    private void uX() {
        this.aft = 0;
    }

    @Override // android.webkit.WebView, android.widget.AbsoluteLayout, android.view.View
    protected void onMeasure(int i, int i2) {
        int screenHeight;
        if (this.aft != 0) {
            int statusBarHeight = d.wV() ? com.kwad.sdk.c.a.a.getStatusBarHeight(getContext()) : 0;
            if (getContext() instanceof Activity) {
                screenHeight = com.kwad.sdk.c.a.a.k((Activity) getContext());
            } else {
                screenHeight = com.kwad.sdk.c.a.a.getScreenHeight(getContext());
            }
            i2 = View.MeasureSpec.makeMeasureSpec((screenHeight - statusBarHeight) - this.aft, 1073741824);
        }
        super.onMeasure(i, i2);
    }

    @Override // com.kwad.sdk.core.webview.KsAdWebView, android.webkit.WebView, android.view.View
    public boolean onTouchEvent(MotionEvent motionEvent) {
        MotionEvent motionEventObtain = MotionEvent.obtain(motionEvent);
        if (this.afR) {
            return super.onTouchEvent(motionEventObtain);
        }
        int actionMasked = MotionEventCompat.getActionMasked(motionEvent);
        float y = motionEvent.getY();
        if (actionMasked == 0) {
            this.afT = y;
            this.afU = false;
            return super.onTouchEvent(motionEvent);
        }
        if (actionMasked != 1) {
            if (actionMasked == 2) {
                float f = this.afT;
                float f2 = f - y;
                a aVar = this.afS;
                if (aVar != null && y <= f) {
                    this.afU = true;
                    aVar.g(f2);
                }
                return super.onTouchEvent(motionEventObtain);
            }
            if (actionMasked != 3) {
                return false;
            }
        }
        a aVar2 = this.afS;
        if (aVar2 == null) {
            return false;
        }
        if ((this.afT - y < 0.0f && !this.afU) || !aVar2.vd()) {
            return false;
        }
        this.afR = true;
        return false;
    }
}
