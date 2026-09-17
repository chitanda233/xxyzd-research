package com.kwad.components.ad.interstitial.f;

import android.content.Context;
import android.graphics.Bitmap;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import androidx.core.graphics.drawable.RoundedBitmapDrawable;
import androidx.core.graphics.drawable.RoundedBitmapDrawableFactory;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsInterstitialAd;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.imageloader.core.assist.FailReason;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener;
import com.kwad.sdk.core.imageloader.utils.BlurUtils;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.utils.i;
import com.kwad.sdk.widget.KSFrameLayout;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.sdk.mvp.a {
    public com.kwad.sdk.core.video.videoview.a cB;
    public KsAdVideoPlayConfig ce;
    public KSFrameLayout gh;
    public com.kwad.components.ad.interstitial.g.b li;
    public KsInterstitialAd.AdInteractionListener lk;
    public com.kwad.components.ad.interstitial.d lp;
    public AdResultData mAdResultData;
    public com.kwad.components.core.e.d.d mApkDownloadHelper;
    public com.kwad.components.ad.interstitial.h.d mG;
    public boolean mH;
    public boolean mI;
    public boolean mJ;
    public a mK;
    public com.kwad.components.core.webview.tachikoma.f.g mM;
    public e mN;
    public boolean mR;
    public boolean mS;
    public List<b> mL = new CopyOnWriteArrayList();
    private Handler jc = new Handler(Looper.getMainLooper());
    public volatile boolean mQ = false;
    public int mT = -1;
    public List<com.kwad.components.core.video.a.c> mP = new CopyOnWriteArrayList();
    public List<d> mO = new ArrayList();

    public interface a {
        void a(long j, long j2, boolean z);
    }

    public interface b {
        void c(long j, long j2);
    }

    public interface d {
        void eg();
    }

    public interface e {
        void eh();
    }

    public final void a(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
    }

    public final void setAdTemplate(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
    }

    public final void a(com.kwad.components.core.video.a.c cVar) {
        if (this.mP.contains(cVar)) {
            return;
        }
        this.mP.add(cVar);
    }

    public final void b(com.kwad.components.core.video.a.c cVar) {
        this.mP.remove(cVar);
    }

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
        this.jc.removeCallbacksAndMessages(null);
        this.mP.clear();
        this.mO.clear();
        com.kwad.components.ad.interstitial.g.b bVar = this.li;
        if (bVar != null) {
            bVar.An();
        }
    }

    public final boolean a(final C0377c c0377c) {
        com.kwad.components.ad.interstitial.report.a.eT().a(this.mAdTemplate, 1L, c0377c.ne);
        boolean z = c0377c.eb() == 1;
        boolean z2 = com.kwad.components.ad.interstitial.b.b.dP() || z || c0377c.ed() || c0377c.ni;
        if (z2) {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(c0377c.getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).as(z).aB(1).aC(c0377c.ne).A(this.cB.getCurrentPosition()).aD(c0377c.eb()).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.interstitial.f.c.1
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    c.this.b(c0377c);
                    if (c.this.lp == null || !com.kwad.components.ad.interstitial.d.b.t(c.this.mAdTemplate)) {
                        return;
                    }
                    c cVar = c.this;
                    cVar.a(false, -1, cVar.cB);
                    c.this.jc.postDelayed(new bi() { // from class: com.kwad.components.ad.interstitial.f.c.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            c.this.lp.dismiss();
                            c.this.ac();
                        }
                    }, 500L);
                }
            }));
        }
        return z2;
    }

    public final void b(C0377c c0377c) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        bVar.f(c0377c.getTouchCoords());
        if (!c0377c.ec() && !c0377c.nf) {
            c0377c.M(MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
        }
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dS(c0377c.ee()).f(c0377c.getTouchCoords()).eg(as.VV() ? 2 : 1).j(c0377c.ef()), (JSONObject) null);
        com.kwad.sdk.core.video.videoview.a aVar = this.cB;
        if (aVar != null) {
            long jA = a(aVar);
            int iB = b(this.cB);
            bVar.az(jA);
            bVar.ea(iB);
        }
        this.mH = true;
        c(1L, c0377c.ne);
    }

    public final void a(final Context context, final int i, int i2, int i3) {
        com.kwad.components.ad.interstitial.report.a.eT().a(this.mAdTemplate, 6L, i);
        final int i4 = 9;
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(context).aF(this.mAdTemplate).b(this.mApkDownloadHelper).as(false).aD(2).aB(6).aC(i).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.interstitial.f.c.2
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                c cVar = c.this;
                int i5 = i4;
                int i6 = i;
                cVar.a(i5, i6, context, 6L, i6);
            }
        }));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, int i2, Context context, long j, long j2) {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dZ(i).dS(i2).eg(as.VV() ? 2 : 1).Jt(), (JSONObject) null);
        this.mH = true;
        c(j, j2);
    }

    public final void ac() {
        KsInterstitialAd.AdInteractionListener adInteractionListener = this.lk;
        if (adInteractionListener != null) {
            adInteractionListener.onAdClosed();
        }
    }

    public final void a(b bVar) {
        if (bVar == null) {
            return;
        }
        this.mL.add(bVar);
    }

    public final void b(b bVar) {
        if (bVar == null) {
            return;
        }
        this.mL.remove(bVar);
    }

    public final void c(long j, long j2) {
        Iterator<b> it = this.mL.iterator();
        while (it.hasNext()) {
            it.next().c(j, j2);
        }
        KsInterstitialAd.AdInteractionListener adInteractionListener = this.lk;
        if (adInteractionListener != null) {
            adInteractionListener.onAdClicked();
        }
        a aVar = this.mK;
        if (aVar != null) {
            aVar.a(j, j2, true);
        }
    }

    public final void dY() {
        e eVar = this.mN;
        if (eVar != null) {
            eVar.eh();
        }
    }

    public final void dZ() {
        Iterator<d> it = this.mO.iterator();
        while (it.hasNext()) {
            it.next().eg();
        }
    }

    public static boolean a(Context context, AdInfo adInfo) {
        return com.kwad.sdk.core.response.helper.a.bc(adInfo) && !as.VV();
    }

    public final boolean M(Context context) {
        if (this.mAdTemplate == null || context == null) {
            com.kwad.sdk.core.d.c.w("InterstitialCallerContext", "isPlayable illegal params: " + this.mAdTemplate + ", context: " + context);
            return false;
        }
        return com.kwad.sdk.core.response.helper.a.bQ(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
    }

    public final void a(Context context, AdInfo adInfo, AdTemplate adTemplate, View view) {
        if (view == null) {
            return;
        }
        String url = com.kwad.sdk.core.response.helper.a.bA(adInfo).getUrl();
        if (br.isNullString(url)) {
            return;
        }
        KSImageLoader.loadImage(url, adTemplate, KSImageLoader.IMGOPTION_NORMAL, new AnonymousClass3(context, view));
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.interstitial.f.c$3, reason: invalid class name */
    final class AnonymousClass3 implements ImageLoadingListener {
        final /* synthetic */ Context dD;
        final /* synthetic */ View eG;

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final boolean onDecode(String str, InputStream inputStream, DecodedResult decodedResult) {
            return false;
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingCancelled(String str, View view) {
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingFailed(String str, View view, FailReason failReason) {
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingStarted(String str, View view) {
        }

        AnonymousClass3(Context context, View view) {
            this.dD = context;
            this.eG = view;
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingComplete(String str, View view, final DecodedResult decodedResult) {
            i.execute(new bi() { // from class: com.kwad.components.ad.interstitial.f.c.3.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    Bitmap bitmap = decodedResult.mBitmap;
                    com.kwad.sdk.core.d.c.d("InterstitialCallerContext", "onLoadingComplete before blur");
                    Bitmap bitmapStackBlur = BlurUtils.stackBlur(bitmap, 50, false);
                    com.kwad.sdk.core.d.c.d("InterstitialCallerContext", "onLoadingComplete after blur");
                    float dimension = AnonymousClass3.this.dD.getResources().getDimension(R.dimen.ksad_interstitial_icon_radius);
                    final RoundedBitmapDrawable roundedBitmapDrawableCreate = RoundedBitmapDrawableFactory.create(AnonymousClass3.this.dD.getResources(), bitmapStackBlur);
                    roundedBitmapDrawableCreate.setCornerRadius(dimension);
                    AnonymousClass3.this.eG.post(new bi() { // from class: com.kwad.components.ad.interstitial.f.c.3.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            AnonymousClass3.this.eG.setBackground(roundedBitmapDrawableCreate);
                        }
                    });
                }
            });
        }
    }

    public final boolean ea() {
        com.kwad.components.ad.interstitial.h.d dVar = this.mG;
        boolean z = dVar == null || dVar.getParent() == null;
        com.kwad.sdk.core.d.c.d("InterstitialCallerContext", "isH5Interstitial :" + z);
        return z;
    }

    public final void c(Context context, AdTemplate adTemplate) {
        if (this.mQ) {
            return;
        }
        com.kwad.components.core.page.a.launch(context, adTemplate);
        this.mQ = true;
    }

    public final void a(boolean z, int i, com.kwad.sdk.core.video.videoview.a aVar) {
        long jA;
        int iA;
        com.kwad.components.ad.interstitial.report.a.eT().a(this.mAdTemplate, cb.k(this.gh, true));
        if (aVar != null) {
            jA = a(aVar);
            iA = b(aVar);
        } else {
            jA = i;
            iA = a(jA, this.mAdTemplate);
        }
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, z ? 14 : 1, jA, iA, this.lp.getTimerHelper().getTime(), null);
    }

    private static long a(com.kwad.sdk.core.video.videoview.a aVar) {
        if (aVar == null) {
            return -1L;
        }
        return aVar.getCurrentPosition();
    }

    private static int b(com.kwad.sdk.core.video.videoview.a aVar) {
        if (aVar == null) {
            return -1;
        }
        long duration = aVar.getDuration();
        long currentPosition = aVar.getCurrentPosition();
        if (duration != 0) {
            return Math.round((currentPosition / duration) * 100.0f);
        }
        return -1;
    }

    private static int a(long j, AdTemplate adTemplate) {
        if (j == -1) {
            return -1;
        }
        float fO = com.kwad.sdk.core.response.helper.a.O(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) / 1000.0f;
        if (fO != 0.0f) {
            return Math.round((j / fO) * 100.0f);
        }
        return -1;
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.interstitial.f.c$c, reason: collision with other inner class name */
    public static class C0377c {
        private final Context context;
        private int nc;
        private boolean nd;
        private int ne;
        private boolean nf;
        private al.a ng;
        public double nh;
        public boolean ni;

        public C0377c(Context context) {
            this.context = context;
        }

        public final Context getContext() {
            return this.context;
        }

        public final int eb() {
            return this.nc;
        }

        public final C0377c L(int i) {
            this.nc = i;
            return this;
        }

        public final boolean ec() {
            return this.nd;
        }

        public final C0377c l(boolean z) {
            this.nd = z;
            return this;
        }

        public final boolean ed() {
            return this.nf;
        }

        public final C0377c m(boolean z) {
            this.nf = true;
            return this;
        }

        public final C0377c n(boolean z) {
            this.ni = true;
            return this;
        }

        public final int ee() {
            return this.ne;
        }

        public final C0377c M(int i) {
            this.ne = i;
            return this;
        }

        public final al.a getTouchCoords() {
            return this.ng;
        }

        public final C0377c a(al.a aVar) {
            this.ng = aVar;
            return this;
        }

        public final double ef() {
            return this.nh;
        }

        public final C0377c c(double d) {
            this.nh = d;
            return this;
        }
    }
}
