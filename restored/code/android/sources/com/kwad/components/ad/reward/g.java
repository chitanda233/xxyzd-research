package com.kwad.components.ad.reward;

import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.ad.reward.k.s;
import com.kwad.components.ad.reward.monitor.LivePlayMonitorType;
import com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.offline.api.core.adlive.IAdLiveOfflineView;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.LiveDetailReward;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bx;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.List;
import java.util.PriorityQueue;
import java.util.Set;
import java.util.concurrent.Callable;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.components.core.n.a {
    public IAdLiveOfflineView dP;
    public boolean iZ;
    public boolean jE;
    private Handler jc;
    public AdResultData mAdResultData;
    public com.kwad.components.ad.reward.e.d mAdRewardStepListener;
    public com.kwad.components.core.e.d.d mApkDownloadHelper;
    public boolean mCheckExposureResult;
    public long mPageEnterTime;
    public JSONObject mReportExtData;
    private boolean mRewardVerifyCalled;
    public AdBaseFrameLayout mRootContainer;
    public boolean mS;
    public int mScreenOrientation;
    public long mStartRenderTime;
    public bx mTimerHelper;
    public KsVideoPlayConfig mVideoPlayConfig;
    private final List<com.kwad.components.ad.reward.m.c> sA;
    public Set<com.kwad.components.ad.reward.e.e> sB;
    private com.kwad.components.core.webview.tachikoma.f.a sC;
    private boolean sD;
    private boolean sE;
    private boolean sF;
    public boolean sG;
    public boolean sH;
    public boolean sI;
    public boolean sJ;
    private boolean sK;
    public boolean sL;
    public boolean sM;
    public List<Integer> sN;
    public int sO;
    public int sP;
    public int sQ;
    public boolean sR;
    public com.kwad.components.ad.reward.n.p sS;
    public boolean sT;
    private PlayableSource sU;
    private boolean sV;
    public long sW;
    private List<DialogInterface.OnDismissListener> sX;
    public com.kwad.components.ad.reward.e.o sY;
    public boolean sZ;
    public boolean sp;
    public com.kwad.components.ad.reward.e.b sq;
    public com.kwad.components.ad.reward.m.e sr;
    public com.kwad.components.core.playable.a ss;
    public RewardActionBarControl st;
    public j su;
    public com.kwad.components.ad.l.a sv;
    public d sw;
    private final PriorityQueue<com.kwad.components.ad.reward.e.g> sx;
    public final List<com.kwad.components.ad.reward.k.a> sy;
    private final List<s> sz;
    public com.kwad.components.ad.reward.l.b.a ta;
    public com.kwad.components.ad.reward.l.a.a tb;
    public int tc;
    private int td;
    public long te;
    public long tf;
    public boolean tg;
    private boolean th;
    private boolean ti;
    public boolean tj;
    public boolean tk;
    public LoadStrategy tl;
    private RewardRenderResult tm;
    private List<a> tn;
    private List<b> to;
    private List<com.kwad.components.core.j.a.InterfaceC0443a> tp;
    private List<com.kwad.components.core.innerEc.live.base.f> tq;

    public interface a {
        void hn();

        void ho();

        void hp();

        void hq();
    }

    public interface b {
        boolean interceptPlayCardResume();
    }

    public final void a(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
    }

    public g(com.kwad.components.core.n.b<?> bVar) {
        super(bVar);
        this.sp = false;
        this.sx = new PriorityQueue<>();
        this.sy = new CopyOnWriteArrayList();
        this.sz = new CopyOnWriteArrayList();
        this.sA = new CopyOnWriteArrayList();
        this.sB = new HashSet();
        this.sD = false;
        this.sE = false;
        this.sF = false;
        this.sH = false;
        this.sI = false;
        this.sJ = false;
        this.sK = false;
        this.sL = false;
        this.mRewardVerifyCalled = false;
        this.sM = false;
        this.sN = new ArrayList();
        this.mCheckExposureResult = true;
        this.sO = 1;
        this.sP = 1;
        this.sQ = 0;
        this.sR = false;
        this.sT = false;
        this.sU = null;
        this.sV = false;
        this.jE = false;
        this.sX = new CopyOnWriteArrayList();
        this.jc = new Handler(Looper.getMainLooper());
        this.sZ = false;
        this.td = 2;
        this.th = false;
        this.ti = false;
        this.tj = false;
        this.tk = false;
        this.tl = LoadStrategy.FULL_TK;
        this.tn = new CopyOnWriteArrayList();
        this.to = new CopyOnWriteArrayList();
        this.tp = new CopyOnWriteArrayList();
        this.tq = new CopyOnWriteArrayList();
        this.abs.add(new com.kwad.components.core.n.a.a() { // from class: com.kwad.components.ad.reward.g.1
            @Override // com.kwad.components.core.n.a.a
            public final void hi() {
                g.this.gM();
            }

            @Override // com.kwad.components.core.n.a.a
            public final void c(com.kwad.components.core.proxy.f fVar) {
                g.this.gN();
            }

            @Override // com.kwad.components.core.n.a.a
            public final void d(com.kwad.components.core.proxy.f fVar) {
                g.this.gO();
            }

            @Override // com.kwad.components.core.n.a.a
            public final void hj() {
                g.this.gP();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void gM() {
        Iterator<a> it = this.tn.iterator();
        while (it.hasNext()) {
            it.next().hn();
        }
    }

    public final void gN() {
        if (this.sF || this.sD || this.th) {
            return;
        }
        Iterator<b> it = this.to.iterator();
        boolean zInterceptPlayCardResume = false;
        while (it.hasNext()) {
            zInterceptPlayCardResume |= it.next().interceptPlayCardResume();
        }
        if (zInterceptPlayCardResume) {
            return;
        }
        Iterator<a> it2 = this.tn.iterator();
        while (it2.hasNext()) {
            it2.next().ho();
        }
    }

    public final void gO() {
        Iterator<a> it = this.tn.iterator();
        while (it.hasNext()) {
            it.next().hp();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void gP() {
        Iterator<a> it = this.tn.iterator();
        while (it.hasNext()) {
            it.next().hq();
        }
    }

    public final void A(boolean z) {
        this.sF = z;
        if (z) {
            gO();
        } else {
            gN();
        }
    }

    public final boolean gQ() {
        return this.sF;
    }

    public final void a(a aVar) {
        this.tn.add(aVar);
    }

    public final void b(a aVar) {
        this.tn.remove(aVar);
    }

    public final void a(b bVar) {
        this.to.add(bVar);
    }

    public final void b(b bVar) {
        this.to.remove(bVar);
    }

    public final void a(com.kwad.components.ad.reward.k.a aVar) {
        this.sy.add(aVar);
    }

    public final void b(com.kwad.components.ad.reward.k.a aVar) {
        this.sy.remove(aVar);
    }

    public final void a(s sVar) {
        this.sz.add(sVar);
    }

    public final void b(s sVar) {
        this.sz.remove(sVar);
    }

    public final void a(com.kwad.components.ad.reward.m.c cVar) {
        if (cVar != null) {
            this.sA.add(cVar);
        }
    }

    public final void b(com.kwad.components.ad.reward.m.c cVar) {
        if (cVar != null) {
            this.sA.remove(cVar);
        }
    }

    public final void a(com.kwad.components.core.innerEc.live.base.f fVar) {
        if (fVar != null) {
            this.tq.add(fVar);
        }
    }

    public final void b(com.kwad.components.core.innerEc.live.base.f fVar) {
        if (fVar != null) {
            this.tq.remove(fVar);
        }
    }

    public final void gR() {
        a(this.sA, new com.kwad.sdk.g.a<com.kwad.components.ad.reward.m.c>() { // from class: com.kwad.components.ad.reward.g.5
            @Override // com.kwad.sdk.g.a
            public final /* synthetic */ void accept(com.kwad.components.ad.reward.m.c cVar) {
                c(cVar);
            }

            private static void c(com.kwad.components.ad.reward.m.c cVar) {
                cVar.jL();
            }
        });
    }

    public static <T> void a(List<T> list, com.kwad.sdk.g.a<T> aVar) {
        if (list != null) {
            Iterator<T> it = list.iterator();
            while (it.hasNext()) {
                aVar.accept(it.next());
            }
        }
    }

    public final void a(LiveDetailReward liveDetailReward) {
        Iterator<com.kwad.components.core.innerEc.live.base.f> it = this.tq.iterator();
        while (it.hasNext()) {
            it.next().b(liveDetailReward);
        }
    }

    public final String gS() {
        if (this.mAdTemplate.tkLiveShopItemInfo == null) {
            return null;
        }
        return this.mAdTemplate.tkLiveShopItemInfo.itemId;
    }

    @Override // com.kwad.components.core.n.a, com.kwad.sdk.mvp.a
    public final void release() {
        gT();
        com.kwad.components.ad.reward.m.e eVar = this.sr;
        if (eVar != null) {
            eVar.release();
        }
    }

    private void gT() {
        this.sx.clear();
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.clear();
        }
        j jVar = this.su;
        if (jVar != null) {
            jVar.release();
        }
        d dVar2 = this.sw;
        if (dVar2 != null) {
            dVar2.release();
        }
        Set<com.kwad.components.ad.reward.e.e> set = this.sB;
        if (set != null) {
            set.clear();
        }
    }

    public static boolean g(AdInfo adInfo) {
        return com.kwad.sdk.core.response.helper.b.g(adInfo) && !com.kwad.components.ad.reward.a.b.l(adInfo);
    }

    public final void b(com.kwad.components.ad.reward.e.g gVar) {
        this.sx.offer(gVar);
    }

    public final void c(com.kwad.components.ad.reward.e.g gVar) {
        this.sx.remove(gVar);
    }

    private static boolean isMainThread() {
        return Looper.getMainLooper() == Looper.myLooper();
    }

    public final void gU() {
        if (isMainThread()) {
            gV();
        } else {
            this.jc.post(new bi() { // from class: com.kwad.components.ad.reward.g.6
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    g.this.gV();
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void gV() {
        try {
            int size = this.sx.size();
            for (int i = 0; i < size; i++) {
                com.kwad.components.ad.reward.e.g gVarPoll = this.sx.poll();
                if (gVarPoll != null) {
                    gVarPoll.cZ();
                }
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void a(long j, long j2, int i) {
        Iterator<com.kwad.components.ad.reward.e.e> it = this.sB.iterator();
        while (it.hasNext()) {
            it.next().du();
        }
    }

    public final void a(int i, Context context, int i2, int i3) {
        b(i, context, i2, i3);
    }

    public final void b(int i, Context context, int i2, int i3) {
        a(i, context, i2, i3, 0L, false, null);
    }

    public final void a(int i, Context context, int i2, int i3, long j) {
        a(1, context, 40, 1, j, false, null);
    }

    public final void a(int i, Context context, final int i2, int i3, long j, boolean z, final com.kwad.sdk.core.adlog.c.b bVar) {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(context).aF(this.mAdTemplate).b(this.mApkDownloadHelper).as(false).aD(i3).A(j).aC(i2).aB(i).an(gS()).a(new Callable<String>() { // from class: com.kwad.components.ad.reward.g.8
            /* JADX INFO: Access modifiers changed from: private */
            @Override // java.util.concurrent.Callable
            /* JADX INFO: renamed from: hl, reason: merged with bridge method [inline-methods] */
            public String call() {
                if (g.this.sr != null) {
                    return g.this.sr.lr().getCurrentShowShopItemInfo().itemId;
                }
                return null;
            }
        }).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.g.7
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                try {
                    g.this.a(i2, bVar);
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        }));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, com.kwad.sdk.core.adlog.c.b bVar) {
        if (bVar == null) {
            bVar = new com.kwad.sdk.core.adlog.c.b();
        }
        bVar.dS(i);
        bVar.f(this.mRootContainer.getTouchCoords());
        com.kwad.components.ad.reward.j.b.a(this.mAdTemplate, (String) null, (String) null, bVar, this.mReportExtData);
        com.kwad.components.ad.reward.c.a.m175if().c(this.mAdTemplate, com.kwad.components.ad.reward.c.b.STATUS_NONE);
        this.sq.cY();
    }

    public final void Z(int i) {
        this.td = i;
    }

    public final void a(DialogInterface.OnDismissListener onDismissListener) {
        this.sX.add(onDismissListener);
    }

    public final void b(DialogInterface.OnDismissListener onDismissListener) {
        this.sX.remove(onDismissListener);
    }

    public final void d(DialogInterface dialogInterface) {
        Iterator<DialogInterface.OnDismissListener> it = this.sX.iterator();
        while (it.hasNext()) {
            it.next().onDismiss(dialogInterface);
        }
    }

    public final void a(com.kwad.components.ad.reward.e.o oVar) {
        this.sY = oVar;
    }

    public final boolean gW() {
        return this.ti;
    }

    public final void B(boolean z) {
        this.ti = z;
    }

    public final void gX() {
        com.kwad.components.core.webview.tachikoma.f.a aVar = this.sC;
        if (aVar == null) {
            return;
        }
        aVar.ku();
    }

    public final void a(com.kwad.components.core.webview.tachikoma.f.a aVar) {
        this.sC = aVar;
    }

    public final boolean gY() {
        return this.sK;
    }

    public final PlayableSource gZ() {
        return this.sU;
    }

    public final void d(PlayableSource playableSource) {
        this.sU = playableSource;
    }

    public final boolean ha() {
        return this.sV;
    }

    public final void C(boolean z) {
        this.sV = true;
    }

    public final void b(com.kwad.components.ad.reward.c.b bVar) {
        com.kwad.components.ad.reward.c.a.m175if().a(this.mAdTemplate, bVar);
    }

    public final void a(final com.kwad.components.core.j.c cVar) {
        final com.kwad.components.core.j.d dVarO = com.kwad.components.ad.reward.e.f.O(this.mAdTemplate.getUniqueId());
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.g.9
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.components.core.j.d dVar = dVarO;
                if (dVar != null) {
                    dVar.c(cVar);
                }
            }
        });
    }

    public final void b(final com.kwad.components.core.j.c cVar) {
        final com.kwad.components.core.j.d dVarO = com.kwad.components.ad.reward.e.f.O(this.mAdTemplate.getUniqueId());
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.g.10
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.components.core.j.d dVar = dVarO;
                if (dVar != null) {
                    dVar.d(cVar);
                }
            }
        });
    }

    public final List<com.kwad.components.core.j.a.InterfaceC0443a> hb() {
        return this.tp;
    }

    public final void a(com.kwad.components.core.j.a.InterfaceC0443a interfaceC0443a) {
        List<com.kwad.components.core.j.a.InterfaceC0443a> list = this.tp;
        if (list != null) {
            list.add(interfaceC0443a);
        }
    }

    public final void b(com.kwad.components.core.j.a.InterfaceC0443a interfaceC0443a) {
        List<com.kwad.components.core.j.a.InterfaceC0443a> list = this.tp;
        if (list != null) {
            list.remove(interfaceC0443a);
        }
    }

    public static com.kwad.components.core.j.c a(List<com.kwad.components.core.j.c> list, long j) {
        if (j >= 0 && list != null) {
            for (com.kwad.components.core.j.c cVar : list) {
                if (com.kwad.sdk.core.response.helper.e.eW(cVar.getAdTemplate()) == j) {
                    return cVar;
                }
            }
        }
        return null;
    }

    public final void a(RewardRenderResult rewardRenderResult) {
        this.tm = rewardRenderResult;
    }

    public final RewardRenderResult hc() {
        return this.tm;
    }

    public final boolean hd() {
        return RewardRenderResult.NEO_TK.equals(this.tm);
    }

    public final boolean he() {
        return this.th;
    }

    public final void D(boolean z) {
        this.th = true;
    }

    public final boolean hf() {
        return this.sE || this.sD;
    }

    public final void E(boolean z) {
        this.sE = z;
    }

    public final void F(boolean z) {
        this.sD = z;
    }

    public final boolean hg() {
        return this.mRewardVerifyCalled;
    }

    public final void G(final boolean z) {
        if (z != this.mRewardVerifyCalled) {
            a(this.sz, new com.kwad.sdk.g.a<s>() { // from class: com.kwad.components.ad.reward.g.11
                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.sdk.g.a
                /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                public void accept(s sVar) {
                    sVar.ac(z);
                }
            });
        }
        this.mRewardVerifyCalled = z;
    }

    public static void a(Context context, g gVar, ViewGroup viewGroup) {
        IAdLiveOfflineView iAdLiveOfflineViewA;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate);
        com.kwad.components.core.offline.a.c.a aVar = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
        if (aVar != null && aVar.tG() && com.kwad.sdk.core.response.helper.a.cY(com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate))) {
            try {
                iAdLiveOfflineViewA = com.kwad.components.ad.j.c.a(aVar, context, com.kwad.sdk.core.response.helper.a.bl(adInfoEM) == 8 ? 1 : 0);
            } catch (Throwable th) {
                com.kwad.components.ad.reward.monitor.b.a(2, ServiceProvider.getAppId(), String.valueOf(com.kwad.sdk.core.response.helper.a.cw(adInfoEM)), Long.valueOf(com.kwad.sdk.core.response.helper.a.cy(adInfoEM)), LivePlayMonitorType.AD_LIVE_IMPL_LOAD_ERROR.getValue(), "AdLiveImpl load error: " + th.getMessage());
                iAdLiveOfflineViewA = null;
            }
            IAdLiveOfflineView iAdLiveOfflineView = iAdLiveOfflineViewA;
            if (iAdLiveOfflineView != null) {
                View view = iAdLiveOfflineView.getView();
                gVar.dP = iAdLiveOfflineView;
                viewGroup.addView(view);
                gVar.sr.a(2, new com.kwad.components.ad.reward.f.a(gVar.mAdTemplate, aVar.getAdLivePlayModule(iAdLiveOfflineView, ServiceProvider.getAppId(), String.valueOf(com.kwad.sdk.core.response.helper.a.cw(adInfoEM)), com.kwad.sdk.core.response.helper.a.cx(adInfoEM), com.kwad.sdk.core.response.helper.a.cy(adInfoEM), com.kwad.sdk.core.response.helper.e.eG(gVar.mAdTemplate)), adInfoEM));
            }
        }
    }

    public static boolean N(AdTemplate adTemplate) {
        return com.kwad.sdk.core.response.helper.e.m(adTemplate, com.kwad.components.ad.reward.a.b.l(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
    }

    public static boolean O(AdTemplate adTemplate) {
        return com.kwad.sdk.core.response.helper.e.O(adTemplate);
    }

    public static boolean P(AdTemplate adTemplate) {
        if (com.kwad.sdk.core.response.helper.a.de(com.kwad.sdk.core.response.helper.e.eM(adTemplate))) {
            return false;
        }
        return N(adTemplate) || O(adTemplate);
    }

    public static long h(AdInfo adInfo) {
        return com.kwad.sdk.core.response.helper.a.ah(adInfo) * 1000;
    }

    public static boolean b(g gVar) {
        return gVar.sD;
    }

    public static void a(g gVar, final h.c cVar, final h.a aVar) {
        com.kwad.components.ad.reward.k.a.b bVarC = null;
        if (!gVar.sr.lq()) {
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate);
            bVarC = com.kwad.components.ad.reward.a.b.k(adInfoEM) || com.kwad.sdk.core.response.helper.a.cq(adInfoEM) == 2 ? c(gVar) : null;
            if (bVarC == null) {
                bVarC = d(gVar);
            }
        }
        com.kwad.components.ad.reward.k.a.b bVar = bVarC;
        if (bVar != null) {
            com.kwad.components.ad.reward.k.a.b.a(bVar, gVar.getActivity(), gVar.sr.getPlayDuration(), aVar, new com.kwad.components.core.webview.tachikoma.d.e.a() { // from class: com.kwad.components.ad.reward.g.12
                @Override // com.kwad.components.core.webview.tachikoma.d.e.a
                public final boolean hm() {
                    g.b(g.this, cVar, aVar);
                    return true;
                }
            });
        } else {
            b(gVar, cVar, aVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void b(g gVar, h.c cVar, h.a aVar) {
        boolean zB = b(gVar);
        com.kwad.sdk.core.d.c.d("RewardCallerContext", "showNativeCloseDialog isCloseDialogShowing: " + zB);
        if (zB) {
            return;
        }
        h.a(gVar.getActivity(), gVar.mAdTemplate, cVar, aVar);
    }

    public final void e(final boolean z, final boolean z2) {
        if (this.sr.lq()) {
            by.runOnUiThreadDelay(new bi() { // from class: com.kwad.components.ad.reward.g.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    com.kwad.components.ad.reward.f.a aVarLr = g.this.sr.lr();
                    if (aVarLr != null) {
                        aVarLr.setAudioEnabled(z, z2);
                    }
                }
            }, 500L);
        }
    }

    public final void C(String str) {
        int iA = -1;
        try {
            if (com.kwad.sdk.core.config.e.Gl()) {
                iA = com.kwad.components.ad.reward.j.a.a(getActivity());
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
        com.kwad.components.ad.reward.j.b.a(this.mContext, this.mAdTemplate, str, iA, this.mReportExtData);
    }

    public final void hh() {
        long j = this.tf;
        com.kwad.sdk.core.adlog.c.i(this.mAdTemplate, com.kwad.sdk.core.response.helper.a.ai(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)), j != 0 ? (int) (j / 1000) : 0);
    }

    private static com.kwad.components.ad.reward.k.a.b c(g gVar) {
        com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
        bVar.a(gVar.mAdResultData);
        bVar.bN(com.kwad.sdk.core.response.helper.b.el(gVar.mAdTemplate));
        bVar.bo(false);
        bVar.bp(true);
        return com.kwad.components.ad.reward.k.a.b.a(gVar, bVar);
    }

    private static com.kwad.components.ad.reward.k.a.b d(g gVar) {
        if (com.kwad.sdk.core.response.helper.a.cq(com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate)) == 4 || com.kwad.sdk.core.response.helper.a.cq(com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate)) == 3) {
            return c(gVar);
        }
        return null;
    }

    public static void a(Activity activity, g gVar) {
        com.kwad.sdk.core.d.c.d("RewardCallerContext", "showExtraDialog");
        com.kwad.components.ad.reward.k.a.b.a(gVar, activity, gVar.sr.getPlayDuration(), new DialogInterface.OnDismissListener() { // from class: com.kwad.components.ad.reward.g.3
            @Override // android.content.DialogInterface.OnDismissListener
            public final void onDismiss(DialogInterface dialogInterface) {
                g.this.d(dialogInterface);
                com.kwad.sdk.core.c.b.Mh();
                Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
                if (currentActivity == null || !currentActivity.equals(g.this.getActivity())) {
                    return;
                }
                g.this.sr.resume();
            }
        }, new h.b() { // from class: com.kwad.components.ad.reward.g.4
            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void hk() {
                g.this.sr.pause();
            }
        });
    }
}
