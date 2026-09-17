package com.kwad.components.ad.l;

import android.app.Activity;
import android.os.Handler;
import android.os.Looper;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.DownloadListener;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.core.webview.a.c;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private c.a ND;
    private b NE;
    private KsAdWebView Nu;
    private boolean Nv;
    private boolean Nw;
    protected AdBaseFrameLayout Nx;
    private InterfaceC0381a Ny;
    private com.kwad.sdk.core.webview.d.a.a fg;
    private FrameLayout fp;
    private AdBaseFrameLayout gF;
    private Activity mActivity;
    private AdTemplate mAdTemplate;
    private ImageView mBackIcon;
    private long mLastDown;
    private boolean Nt = true;
    private Handler jc = new Handler(Looper.getMainLooper());
    private boolean Nz = false;
    private boolean NB = false;
    private boolean NC = false;

    /* JADX INFO: renamed from: com.kwad.components.ad.l.a$a, reason: collision with other inner class name */
    public interface InterfaceC0381a {
        void T(boolean z);
    }

    public interface b {
        void jQ();
    }

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.NB = true;
        return true;
    }

    static /* synthetic */ boolean b(a aVar, boolean z) {
        aVar.Nt = true;
        return true;
    }

    static /* synthetic */ boolean c(a aVar, boolean z) {
        aVar.Nz = true;
        return true;
    }

    static /* synthetic */ boolean d(a aVar, boolean z) {
        aVar.Nv = true;
        return true;
    }

    public final a ai(boolean z) {
        this.Nw = true;
        return this;
    }

    public final void bf() {
        this.fp.setVisibility(4);
        String strK = K(this.mAdTemplate);
        if (TextUtils.isEmpty(strK)) {
            return;
        }
        this.Nu.loadUrl(strK);
    }

    public final void a(InterfaceC0381a interfaceC0381a) {
        this.Ny = interfaceC0381a;
    }

    private void gC() {
        this.fp.removeAllViews();
        this.fp.setVisibility(4);
        this.Nx = (AdBaseFrameLayout) ((ViewGroup) com.kwad.sdk.c.a.a.a((ViewGroup) this.fp, R.layout.ksad_ad_landingpage_layout, true)).findViewById(R.id.ksad_web_card_frame);
        KsAdWebView ksAdWebView = (KsAdWebView) this.fp.findViewById(R.id.ksad_web_card_webView);
        this.Nu = ksAdWebView;
        ksAdWebView.setBackgroundColor(-1);
        c.a aVarB = this.Nu.getClientConfig().bR(false).bV(true).bU(false).bQ(true).fm(this.mAdTemplate).a(on()).b(jE());
        this.ND = aVarB;
        this.Nu.setClientConfig(aVarB);
        this.Nu.setDownloadListener(new DownloadListener() { // from class: com.kwad.components.ad.l.a.1
            @Override // android.webkit.DownloadListener
            public final void onDownloadStart(String str, String str2, String str3, String str4, long j) {
                a.a(a.this, true);
                if (a.this.Ny != null) {
                    a.this.Ny.T(a.this.cJ());
                }
            }
        });
        ImageView imageView = (ImageView) this.Nx.findViewById(R.id.ksad_end_close_btn);
        this.mBackIcon = imageView;
        imageView.setVisibility(8);
        this.mBackIcon.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.l.a.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (a.this.NE != null) {
                    a.this.NE.jQ();
                }
            }
        });
    }

    public final void a(FrameLayout frameLayout, AdBaseFrameLayout adBaseFrameLayout, AdTemplate adTemplate) {
        this.fp = frameLayout;
        this.gF = adBaseFrameLayout;
        this.mAdTemplate = adTemplate;
        gC();
        this.Nt = false;
    }

    private KsAdWebView.e jE() {
        return new KsAdWebView.e() { // from class: com.kwad.components.ad.l.a.3
            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageStart() {
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str, String str2) {
                a.b(a.this, true);
                if (a.this.Ny != null) {
                    a.this.Ny.T(a.this.cJ());
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
                if (a.this.Ny != null) {
                    a.this.Ny.T(a.this.cJ());
                }
            }
        };
    }

    private KsAdWebView.b on() {
        return new KsAdWebView.b() { // from class: com.kwad.components.ad.l.a.4
            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onSuccess() {
                a.c(a.this, true);
                if (a.this.Ny != null) {
                    a.this.Ny.T(a.this.cJ());
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onFailed() {
                a.c(a.this, true);
                if (a.this.Ny != null) {
                    a.this.Ny.T(a.this.cJ());
                }
            }
        };
    }

    public final void a(b bVar) {
        this.NE = bVar;
    }

    public final void setActivity(Activity activity) {
        this.mActivity = activity;
    }

    private static String K(AdTemplate adTemplate) {
        return com.kwad.sdk.core.response.helper.a.aY(e.eM(adTemplate));
    }

    public final void a(com.kwad.sdk.core.webview.d.a.a aVar) {
        this.fg = aVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean cJ() {
        if (this.NC) {
            return !this.Nt;
        }
        return (this.Nt || this.Nz || this.NB) ? false : true;
    }

    private boolean oo() {
        if (cJ()) {
            FrameLayout frameLayout = this.fp;
            if (frameLayout == null) {
                return true;
            }
            frameLayout.setVisibility(0);
            return true;
        }
        FrameLayout frameLayout2 = this.fp;
        if (frameLayout2 != null) {
            frameLayout2.setVisibility(8);
        }
        return false;
    }

    public final boolean aY() {
        boolean zOo = oo();
        this.NC = true;
        if (zOo && this.mActivity != null) {
            if (this.Nu.getClientConfig() != null) {
                this.Nu.getClientConfig().bR(true);
                this.Nu.getClientConfig().bU(true);
            }
            this.Nx.a(new View.OnTouchListener() { // from class: com.kwad.components.ad.l.a.5
                @Override // android.view.View.OnTouchListener
                public final boolean onTouch(View view, MotionEvent motionEvent) {
                    if (motionEvent.getX() > a.this.mBackIcon.getX() && motionEvent.getX() - a.this.mBackIcon.getX() < a.this.mBackIcon.getWidth() && motionEvent.getY() > a.this.mBackIcon.getY() && motionEvent.getY() - a.this.mBackIcon.getY() < a.this.mBackIcon.getHeight()) {
                        com.kwad.sdk.core.d.c.d("LandingPageWebCard", "onClick backIcon");
                        return false;
                    }
                    if (motionEvent.getAction() == 0) {
                        a.this.mLastDown = SystemClock.elapsedRealtime();
                    } else if (motionEvent.getAction() == 1) {
                        long jElapsedRealtime = SystemClock.elapsedRealtime() - a.this.mLastDown;
                        if (a.this.mLastDown > 0 && jElapsedRealtime > 30 && jElapsedRealtime < 500) {
                            com.kwad.sdk.core.adlog.c.a(a.this.mAdTemplate, 155, a.this.gF.getTouchCoords());
                            if (!a.this.Nv) {
                                a.d(a.this, true);
                                if (a.this.fg != null) {
                                    com.kwad.sdk.core.webview.d.b.a aVar = new com.kwad.sdk.core.webview.d.b.a();
                                    aVar.arc = 3;
                                    a.this.fg.a(aVar);
                                }
                            }
                        }
                        a.this.mLastDown = 0L;
                    }
                    return false;
                }
            });
            long jAq = com.kwad.sdk.core.response.helper.a.aq(e.eM(this.mAdTemplate));
            if (jAq == 0 || !this.Nw) {
                this.mBackIcon.setVisibility(0);
            } else {
                this.jc.postDelayed(new Runnable() { // from class: com.kwad.components.ad.l.a.6
                    @Override // java.lang.Runnable
                    public final void run() {
                        if (a.this.mActivity == null || a.this.mActivity.isFinishing()) {
                            return;
                        }
                        a.this.mBackIcon.setVisibility(0);
                        a.this.mBackIcon.setAlpha(0.0f);
                        a.this.mBackIcon.animate().alpha(1.0f).setDuration(500L).start();
                    }
                }, jAq);
            }
            KsAdWebView ksAdWebView = this.Nu;
            if (ksAdWebView != null) {
                ksAdWebView.onActivityCreate();
            }
        }
        return zOo;
    }
}
