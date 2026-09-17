package com.kwad.components.core.playable;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import com.kwad.components.core.e.d.d;
import com.kwad.components.core.webview.jshandler.ag;
import com.kwad.components.core.webview.jshandler.ah;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bj;
import com.kwad.components.core.webview.jshandler.j;
import com.kwad.components.core.webview.jshandler.n;
import com.kwad.components.core.webview.jshandler.o;
import com.kwad.components.core.webview.jshandler.p;
import com.kwad.components.core.webview.tachikoma.b.f;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.core.webview.b;
import com.kwad.sdk.utils.by;
import java.lang.ref.WeakReference;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements p {
    private final KsAdWebView aiE;
    private long aiF;
    private int aiG;
    private PlayableSource aiH = PlayableSource.UNKNOWN_TRYPLAY_ENTRY_SOURCE;
    private List<as.b> aiI = new CopyOnWriteArrayList();
    private List<KsAdWebView.e> aiJ = new CopyOnWriteArrayList();
    private com.kwad.components.core.webview.a fb;
    private az ff;
    private AdTemplate mAdTemplate;
    private d mApkDownloadHelper;
    private Context mContext;
    private AdBaseFrameLayout mRootContainer;

    public a(KsAdWebView ksAdWebView) {
        this.aiE = ksAdWebView;
        ksAdWebView.setOnTouchListener(new View.OnTouchListener() { // from class: com.kwad.components.core.playable.a.1
            @Override // android.view.View.OnTouchListener
            public final boolean onTouch(View view, MotionEvent motionEvent) {
                if (motionEvent.getAction() != 0) {
                    return false;
                }
                a.this.aiF = SystemClock.elapsedRealtime();
                a.this.aiE.getClientConfig().bR(true);
                return false;
            }
        });
        ksAdWebView.setClientConfig(ksAdWebView.getClientConfig().fm(this.mAdTemplate).b(jE()));
        a(ksAdWebView);
    }

    private KsAdWebView.e jE() {
        return new KsAdWebView.e() { // from class: com.kwad.components.core.playable.a.2
            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str, String str2) {
                Iterator it = a.this.aiJ.iterator();
                while (it.hasNext()) {
                    ((KsAdWebView.e) it.next()).onReceivedHttpError(i, str, str2);
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageStart() {
                Iterator it = a.this.aiJ.iterator();
                while (it.hasNext()) {
                    ((KsAdWebView.e) it.next()).onPageStart();
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
                Iterator it = a.this.aiJ.iterator();
                while (it.hasNext()) {
                    ((KsAdWebView.e) it.next()).onPageFinished();
                }
            }
        };
    }

    private static void a(KsAdWebView ksAdWebView) {
        if (e.Ku()) {
            ksAdWebView.getSettings().setMediaPlaybackRequiresUserGesture(false);
        }
    }

    public final void a(AdTemplate adTemplate, AdBaseFrameLayout adBaseFrameLayout, d dVar) {
        if (this.aiE == null) {
            c.w("PlayableViewHelper", "registerJsBridge mPlayableView is null");
            return;
        }
        this.mContext = adBaseFrameLayout.getContext();
        this.mRootContainer = adBaseFrameLayout;
        this.mAdTemplate = adTemplate;
        this.mApkDownloadHelper = dVar;
        this.aiG = -1;
        b bVar = new b();
        bVar.setAdTemplate(adTemplate);
        bVar.mScreenOrientation = 0;
        bVar.bbV = this.mRootContainer;
        bVar.adZ = this.mRootContainer;
        bVar.adg = this.aiE;
        bh();
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(this.aiE);
        this.fb = aVar;
        a(bVar, aVar, dVar);
        this.aiE.addJavascriptInterface(this.fb, "KwaiAd");
    }

    public final void vJ() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    public final void a(as.b bVar) {
        this.aiI.add(bVar);
    }

    public final void b(as.b bVar) {
        this.aiI.remove(bVar);
    }

    public final void a(KsAdWebView.e eVar) {
        this.aiJ.add(eVar);
    }

    public final void vK() {
        KsAdWebView ksAdWebView;
        if (this.mAdTemplate == null || (ksAdWebView = this.aiE) == null) {
            return;
        }
        ksAdWebView.getClientConfig().bR(false);
        String url = getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.aiE.loadUrl(url);
        }
        com.kwad.sdk.core.adlog.c.cv(this.mAdTemplate);
    }

    public final long getLoadTime() {
        KsAdWebView ksAdWebView = this.aiE;
        if (ksAdWebView != null) {
            return ksAdWebView.getLoadTime();
        }
        return -1L;
    }

    private String getUrl() {
        AdTemplate adTemplate = this.mAdTemplate;
        return adTemplate == null ? "" : com.kwad.sdk.core.response.helper.a.bX(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
    }

    public final void e(PlayableSource playableSource) {
        if (playableSource != null) {
            this.aiH = playableSource;
        }
        if (this.aiE == null) {
            return;
        }
        uH();
        c.d("PlayableViewHelper", "showPlayable");
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yJ();
        }
        this.aiE.setVisibility(0);
        az azVar2 = this.ff;
        if (azVar2 != null) {
            azVar2.yK();
        }
    }

    public final void iU() {
        c.d("PlayableViewHelper", "showPlayable");
        if (this.aiE == null) {
            return;
        }
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yL();
        }
        this.aiE.setVisibility(8);
        az azVar2 = this.ff;
        if (azVar2 != null) {
            azVar2.yM();
        }
        this.aiE.reload();
    }

    public final boolean vL() {
        return this.aiE != null && this.aiG == 1;
    }

    private AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    private void a(b bVar, com.kwad.components.core.webview.a aVar, d dVar) {
        aVar.a(new bj(bVar, dVar, new C0457a(this)));
        aVar.a(new as(new as.b() { // from class: com.kwad.components.core.playable.a.3
            @Override // com.kwad.components.core.webview.jshandler.as.b
            public final void a(as.a aVar2) {
                a.this.aiG = aVar2.status;
                if (aVar2.status == 1 && a.this.mAdTemplate != null) {
                    com.kwad.sdk.core.adlog.c.cu(a.this.mAdTemplate);
                }
                Iterator it = a.this.aiI.iterator();
                while (it.hasNext()) {
                    ((as.b) it.next()).a(aVar2);
                }
            }
        }, getUrl()));
        aVar.a(new am(bVar));
        aVar.b(new o(bVar));
        aVar.b(new n(bVar));
        this.ff = new az();
        aVar.a(new ah());
        aVar.a(new ag(bVar));
        aVar.a(new f());
        aVar.a(this.ff);
        aVar.a(new j(this));
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    @Override // com.kwad.components.core.webview.jshandler.p
    public final void a(j jVar, String str) {
        AdTemplate adTemplate;
        if ("playableSrc".equals(str)) {
            jVar.f(this.aiH);
        }
        if (!"getAdType".equals(str) || (adTemplate = this.mAdTemplate) == null) {
            return;
        }
        jVar.bS(adTemplate.adStyle);
    }

    /* JADX INFO: renamed from: com.kwad.components.core.playable.a$a, reason: collision with other inner class name */
    static class C0457a implements bj.b {
        private final WeakReference<a> aiL;

        public C0457a(a aVar) {
            this.aiL = new WeakReference<>(aVar);
        }

        @Override // com.kwad.components.core.webview.jshandler.bj.b
        public final void ae(int i) {
            a aVar = this.aiL.get();
            if (aVar != null) {
                aVar.bF(i);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bF(int i) {
        if (getAdTemplate() == null) {
            return;
        }
        long jKv = e.Kv();
        if (jKv <= 0 || SystemClock.elapsedRealtime() - this.aiF <= jKv) {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(this.mContext).aF(this.mAdTemplate).b(this.mApkDownloadHelper).as(false).aC(i).d(this.mRootContainer.getTouchCoords()).au(true));
        }
    }

    private void uH() {
        if (com.kwad.sdk.core.response.helper.a.bT(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)) > 0) {
            by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.core.playable.a.4
                @Override // java.lang.Runnable
                public final void run() {
                    a.this.aiE.getClientConfig().bR(true);
                }
            }, com.kwad.sdk.core.response.helper.a.bT(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)));
        }
        if (com.kwad.sdk.core.response.helper.a.bT(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)) == 0) {
            this.aiE.getClientConfig().bR(true);
        }
    }
}
