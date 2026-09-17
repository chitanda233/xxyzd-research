package com.sigmob.sdk.base.views;

import android.content.Context;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.utils.Md5Util;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public class o extends g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3348a = "o";
    private final com.sigmob.sdk.base.views.b b;
    private a c;

    public interface a {
        void onWebViewClick(MotionEvent downEvent, MotionEvent upEvent);
    }

    class b implements View.OnTouchListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        MotionEvent f3349a;
        private boolean c;

        b() {
        }

        @Override // android.view.View.OnTouchListener
        public boolean onTouch(View v, MotionEvent event) {
            int action = event.getAction();
            if (action == 0) {
                this.c = true;
                this.f3349a = MotionEvent.obtain(event);
            } else {
                if (action != 1 || !this.c) {
                    return false;
                }
                this.c = false;
                if (o.this.c != null) {
                    o.this.c.onWebViewClick(this.f3349a, event);
                }
            }
            return false;
        }
    }

    private o(Context context, String adLogoUrl, boolean showAdLogo, boolean invisibleAdLabel) {
        super(context);
        j();
        com.sigmob.sdk.base.utils.j.a(f3348a, getSettings());
        a(true);
        setBackgroundColor(0);
        if (showAdLogo) {
            ViewGroup.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -2);
            com.sigmob.sdk.base.views.b bVar = new com.sigmob.sdk.base.views.b(getContext().getApplicationContext(), 1);
            this.b = bVar;
            bVar.a(adLogoUrl);
            bVar.b(com.sigmob.sdk.base.k.h());
            addView(bVar, layoutParams);
        } else {
            this.b = null;
        }
        setOnTouchListener(new b());
    }

    public static o a(Context context, String adLogoUrl, boolean showAdLogo, boolean invisibleAdLabel) {
        Preconditions.NoThrow.checkNotNull(context);
        return new o(context, adLogoUrl, showAdLogo, invisibleAdLabel);
    }

    private void j() {
        setHorizontalScrollBarEnabled(false);
        setHorizontalScrollbarOverlay(false);
        setVerticalScrollBarEnabled(false);
        setVerticalScrollbarOverlay(false);
        getSettings().setSupportZoom(false);
        setScrollBarStyle(0);
    }

    void a(String data) {
        File fileB = com.sigmob.sdk.base.utils.n.b(data, Md5Util.md5(data) + ".html");
        if (fileB == null || TextUtils.isEmpty(fileB.getAbsolutePath())) {
            loadDataWithBaseURL(Networking.getBaseUrlScheme() + "://localhost/", data, "text/html", "utf-8", null);
        } else {
            loadUrl("file://" + fileB.getAbsolutePath());
        }
    }

    @Override // com.sigmob.sdk.base.views.g, android.webkit.WebView
    public void destroy() {
        SigmobLog.d("CreativeWebView destroy() callSigmobLog.d( \"CreativeWebView destroy() called\");ed");
        super.destroy();
        removeAllViews();
    }

    public void setLogoClickListener(View.OnClickListener listener) {
        com.sigmob.sdk.base.views.b bVar = this.b;
        if (bVar == null) {
            return;
        }
        bVar.setOnClickListener(listener);
    }

    public void setWebViewClickListener(a webViewClickListener) {
        this.c = webViewClickListener;
    }
}
