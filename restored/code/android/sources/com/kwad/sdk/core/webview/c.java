package com.kwad.sdk.core.webview;

import android.content.Context;
import android.util.AttributeSet;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.webkit.WebView;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.cd;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class c extends WebView {
    private boolean bca;
    private com.kwad.sdk.core.webview.a.a bcb;

    public c(Context context) {
        super(cn(context));
        this.bca = true;
        init();
    }

    public c(Context context, AttributeSet attributeSet) {
        super(cn(context), attributeSet);
        this.bca = true;
        init();
    }

    public c(Context context, AttributeSet attributeSet, int i) {
        super(cn(context), attributeSet, i);
        this.bca = true;
        init();
    }

    public c(Context context, AttributeSet attributeSet, int i, int i2) {
        super(cn(context), attributeSet, i, i2);
        this.bca = true;
        init();
    }

    public c(Context context, AttributeSet attributeSet, int i, boolean z) {
        super(cn(context), attributeSet, i, z);
        this.bca = true;
        init();
    }

    public void setNeedHybridLoad(boolean z) {
        this.bcb.setNeedHybridLoad(z);
    }

    private void init() {
        cd.b(this);
        com.kwad.sdk.core.webview.a.a aVar = new com.kwad.sdk.core.webview.a.a();
        this.bcb = aVar;
        setWebViewClient(aVar);
    }

    private static Context cn(Context context) {
        Context contextEL = m.eL(context);
        if (m.eO(contextEL)) {
            return contextEL;
        }
        ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(new IllegalArgumentException("KSApiWebView context not except--context:" + contextEL.getClass().getName() + "--classloader:" + contextEL.getClass().getClassLoader() + "--context2:" + m.eL(ServiceProvider.Um()).getClass().getName()));
        return m.eL(ServiceProvider.Um());
    }

    public void setEnableDestroy(boolean z) {
        this.bca = z;
    }

    @Override // android.webkit.WebView
    public void destroy() {
        if (this.bca) {
            release();
        }
    }

    public final void release() {
        try {
            ViewParent parent = getParent();
            if (parent instanceof ViewGroup) {
                ((ViewGroup) parent).removeView(this);
            }
            removeAllViews();
            super.destroy();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }
}
