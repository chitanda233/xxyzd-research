package com.kwad.components.core.e.d;

import android.app.Activity;
import android.content.Context;
import android.text.TextUtils;
import com.kwad.components.core.innerEc.logger.InnerEcError;
import com.kwad.components.core.innerEc.logger.InnerEcEvent;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.page.AdWebViewVideoActivityProxy;
import com.kwad.components.core.webview.tachikoma.b.k;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.track.AdTrackLog;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.wrapper.m;
import java.lang.ref.WeakReference;
import java.util.List;
import java.util.concurrent.Callable;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static InnerEcEvent QA;
    public static InnerEcError QB;
    private static List<WeakReference<k.b>> Qz;

    public interface b {
        void onAdClicked();
    }

    public static int a(Context context, AdTemplate adTemplate, b bVar, d dVar, boolean z, boolean z2, boolean z3, boolean z4) {
        com.kwad.sdk.commercial.convert.a.g(adTemplate, true);
        adTemplate.converted = true;
        e.aD(false);
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
        C0428a c0428aAv = new C0428a(context).aF(adTemplate).a(bVar).b(dVar).as(z).at(z2).ap(z4).av(false);
        int iAt = com.kwad.sdk.core.response.helper.a.at(adInfoEM);
        if (!(z3 || c0428aAv.qg() == 2 || c0428aAv.qg() == 1) && !TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aY(adInfoEM)) && !c0428aAv.qc()) {
            if (iAt == 1) {
                if (com.kwad.sdk.core.response.helper.a.bo(adInfoEM)) {
                    return k(c0428aAv);
                }
                return l(c0428aAv);
            }
            if (iAt == 2) {
                int iH = h(c0428aAv);
                if (iH == 1) {
                    return 13;
                }
                if (iH == 2) {
                    return 16;
                }
                if (com.kwad.sdk.core.response.helper.a.bo(adInfoEM)) {
                    return k(c0428aAv);
                }
                return l(c0428aAv);
            }
        }
        int iH2 = h(c0428aAv);
        if (iH2 == 1) {
            return 13;
        }
        if (iH2 == 2) {
            return 16;
        }
        if (!com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
            if (j(c0428aAv)) {
                return 11;
            }
            return l(c0428aAv);
        }
        int iM = m(c0428aAv);
        if (adInfoEM.status != 2 && adInfoEM.status != 3) {
            e(c0428aAv);
        }
        return iM;
    }

    public static int a(C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        e.aD(false);
        if (c0428a.pU()) {
            return b(c0428a);
        }
        if (c0428a.qd()) {
            return a(context, adTemplate, c0428a.pQ(), c0428a.it(), c0428a.QL, c0428a.pX(), false, c0428a.pT());
        }
        com.kwad.sdk.commercial.convert.a.g(adTemplate, false);
        if (c(c0428a)) {
            d(adTemplate, 1);
            return 1;
        }
        adTemplate.converted = true;
        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
        boolean zAG = com.kwad.components.core.innerEc.f.aG(adTemplate);
        if (com.kwad.sdk.core.response.helper.a.dG(adInfoEM)) {
            com.kwad.components.core.innerEc.logger.a.d(adTemplate, c0428a.qj());
        }
        if (zAG && !adTemplate.hasInnerEcFailed() && !c0428a.qj()) {
            QB = InnerEcError.createEmptyError(adTemplate);
            QA = InnerEcEvent.createEmptyEvent(adTemplate);
            e(c0428a);
            c0428a.aB(true);
            int iA = com.kwad.components.core.innerEc.f.a(context, adTemplate, c0428a);
            if (iA == 1) {
                return 14;
            }
            if (iA == 2) {
                com.kwad.components.core.innerEc.qcpx.b.h(context, adTemplate);
                if (com.kwad.sdk.core.response.helper.e.fk(adTemplate)) {
                    com.kwad.components.core.innerEc.live.b.c(com.kwad.sdk.core.c.b.Mh().getApplication());
                    com.kwad.components.core.innerEc.live.b.b(context, adTemplate, c0428a);
                    return 14;
                }
                com.kwad.components.core.innerEc.f.g(context, adTemplate);
                return 14;
            }
            if (iA == 3) {
                return com.kwad.components.core.innerEc.f.G(c0428a);
            }
        }
        int iAt = com.kwad.sdk.core.response.helper.a.at(adInfoEM);
        if (!(c0428a.qg() == 2 || c0428a.qg() == 1) && !TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aY(adInfoEM)) && !c0428a.qc()) {
            if (iAt == 1) {
                if (com.kwad.sdk.core.response.helper.a.bo(adInfoEM)) {
                    return k(c0428a);
                }
                return l(c0428a);
            }
            if (iAt == 2) {
                int iH = h(c0428a);
                if (iH == 1) {
                    return 13;
                }
                if (iH == 2) {
                    return 16;
                }
                if (com.kwad.sdk.core.response.helper.a.bo(adInfoEM)) {
                    return k(c0428a);
                }
                return l(c0428a);
            }
        }
        int iH2 = h(c0428a);
        if (iH2 == 1) {
            return 13;
        }
        if (iH2 == 2) {
            return 16;
        }
        int i = i(c0428a);
        if (i == 1) {
            return 12;
        }
        if (i == 2) {
            return 17;
        }
        if (c0428a.qb() && !com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
            return n(c0428a);
        }
        if (!com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
            if (adTemplate.isWebViewDownload) {
                int iM = m(c0428a);
                adTemplate.isWebViewDownload = false;
                return iM;
            }
            if (j(c0428a)) {
                return 11;
            }
            return l(c0428a);
        }
        if (c0428a.qg() == 2 || c0428a.qg() == 1) {
            c0428a.av(false);
            e(c0428a);
            return m(c0428a);
        }
        if (c0428a.qb() && com.kwad.sdk.core.response.helper.a.b(adInfoEM, com.kwad.sdk.core.config.e.JU()) && !TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aY(adInfoEM)) && !AdWebViewVideoActivityProxy.showingAdWebViewVideoActivity) {
            int iU = c0428a.it().u(c0428a);
            if (iU == 0) {
                return k(c0428a);
            }
            e(c0428a);
            d(adTemplate, iU);
            return iU;
        }
        e(c0428a);
        c0428a.av(true);
        return m(c0428a);
    }

    private static int b(C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        Activity activityFromContext = m.getActivityFromContext(context);
        if (activityFromContext != null && com.kwad.sdk.core.response.helper.a.Y(adInfoEM) && !c0428a.pO() && !c0428a.pT()) {
            c0428a.aA(2);
            com.kwad.components.core.e.e.e.a(activityFromContext, c0428a);
            d(adTemplate, 19);
            return 19;
        }
        AdWebViewActivityProxy.launch(context, new AdWebViewActivityProxy.a.C0449a().aX(com.kwad.sdk.core.response.helper.b.dh(adTemplate)).aU(adTemplate).aR(true).um());
        d(adTemplate, 20);
        return 20;
    }

    public static boolean c(C0428a c0428a) {
        if (com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(c0428a.getAdTemplate()))) {
            return !c0428a.qe() && d.E(c0428a) == 3;
        }
        return d(c0428a) == 1;
    }

    private static int d(C0428a c0428a) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(c0428a.getAdTemplate());
        if (adInfoEM.unDownloadConf.unDownloadRegionConf == null) {
            return 0;
        }
        int iEb = c0428a.eb();
        if (iEb == 2) {
            return adInfoEM.unDownloadConf.unDownloadRegionConf.describeBarType;
        }
        if (iEb == 3) {
            return adInfoEM.unDownloadConf.unDownloadRegionConf.materialJumpType;
        }
        return adInfoEM.unDownloadConf.unDownloadRegionConf.actionBarType;
    }

    private static void e(C0428a c0428a) {
        if (c0428a.pO() || c0428a.qi()) {
            return;
        }
        g(c0428a);
        f(c0428a);
        if (c0428a.pQ() != null) {
            try {
                c0428a.pQ().onAdClicked();
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
        com.kwad.sdk.commercial.convert.a.bG(c0428a.getAdTemplate());
        aE(c0428a.getAdTemplate());
    }

    private static void aE(AdTemplate adTemplate) {
        AdInfo adInfoEM;
        if (adTemplate == null || (adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate)) == null) {
            return;
        }
        adInfoEM.convertCount++;
    }

    private static void f(C0428a c0428a) {
        if (c0428a.pY()) {
            com.kwad.sdk.core.adlog.c.a(c0428a.adTemplate, c0428a.pZ(), c0428a.iI());
        }
    }

    public static void a(k.b bVar) {
        if (Qz == null) {
            Qz = new CopyOnWriteArrayList();
        }
        Qz.add(new WeakReference<>(bVar));
    }

    public static void b(k.b bVar) {
        if (Qz == null) {
            return;
        }
        int i = 0;
        while (true) {
            if (i >= Qz.size()) {
                i = -1;
                break;
            }
            WeakReference<k.b> weakReference = Qz.get(i);
            if (weakReference != null && weakReference.get() != null && bVar == weakReference.get()) {
                break;
            } else {
                i++;
            }
        }
        if (i != -1) {
            Qz.remove(i);
        }
    }

    private static void g(C0428a c0428a) {
        k.b bVar;
        List<WeakReference<k.b>> list = Qz;
        if (list == null || list.isEmpty() || c0428a.adTemplate == null) {
            return;
        }
        for (WeakReference<k.b> weakReference : Qz) {
            if (weakReference != null && (bVar = weakReference.get()) != null) {
                bVar.V(com.kwad.sdk.core.response.helper.e.eW(c0428a.adTemplate));
            }
        }
    }

    private static int h(C0428a c0428a) {
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        int iA = e.a(c0428a, 1);
        if (iA == 1) {
            e.aD(true);
            e(c0428a);
            if ((com.kwad.sdk.core.response.helper.a.cX(adInfoEM) || com.kwad.sdk.core.response.helper.a.cY(adInfoEM)) && !c0428a.qh()) {
                com.kwad.sdk.core.adlog.c.p(c0428a.getAdTemplate(), (int) Math.ceil(c0428a.pW() / 1000.0f));
            }
            d(adTemplate, 13);
        } else if (iA == 2) {
            e(c0428a);
            d(adTemplate, 16);
        }
        return iA;
    }

    private static int i(C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(c0428a.getAdTemplate());
        Activity activityFromContext = m.getActivityFromContext(c0428a.getContext());
        if (activityFromContext != null && com.kwad.sdk.core.response.helper.a.W(adInfoEM) && !c0428a.pO() && f.G(adInfoEM) && !c0428a.pT()) {
            c0428a.aA(1);
            com.kwad.components.core.e.e.e.a(activityFromContext, c0428a);
            e(c0428a);
            d(adTemplate, 17);
            return 2;
        }
        int iE = f.e(context, adTemplate);
        if (iE == 1) {
            e(c0428a);
            d(adTemplate, 12);
        }
        return iE;
    }

    private static boolean j(C0428a c0428a) {
        AdTemplate adTemplate = c0428a.getAdTemplate();
        boolean zL = com.kwad.sdk.utils.f.l(c0428a.getContext(), adTemplate);
        if (zL) {
            e(c0428a);
            com.kwad.sdk.core.adlog.c.n(adTemplate, 0);
            d(adTemplate, 11);
        }
        return zL;
    }

    private static int k(C0428a c0428a) {
        e(c0428a);
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(c0428a.getAdTemplate());
        Activity activityFromContext = m.getActivityFromContext(c0428a.getContext());
        if (activityFromContext != null && com.kwad.sdk.core.response.helper.a.Y(adInfoEM) && !c0428a.pO() && !c0428a.pT()) {
            c0428a.aA(2);
            com.kwad.components.core.e.e.e.a(activityFromContext, c0428a);
            d(adTemplate, 19);
            return 19;
        }
        AdWebViewVideoActivityProxy.launch(c0428a.getContext(), adTemplate);
        d(adTemplate, 15);
        return 15;
    }

    private static int l(C0428a c0428a) {
        e(c0428a);
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        Activity activityFromContext = m.getActivityFromContext(context);
        if (activityFromContext != null && com.kwad.sdk.core.response.helper.a.Y(adInfoEM) && !c0428a.pO() && !c0428a.pT()) {
            c0428a.aA(2);
            com.kwad.components.core.e.e.e.a(activityFromContext, c0428a);
            d(adTemplate, 19);
            return 19;
        }
        AdWebViewActivityProxy.launch(context, new AdWebViewActivityProxy.a.C0449a().aX(com.kwad.sdk.core.response.helper.b.dh(adTemplate)).aU(adTemplate).aS(c0428a.pR()).bl(com.kwad.components.core.innerEc.f.aG(adTemplate) ? 2 : 1).um());
        d(adTemplate, 14);
        return 14;
    }

    private static int m(C0428a c0428a) {
        d dVarIt = c0428a.it();
        if (dVarIt == null) {
            dVarIt = new d(c0428a.adTemplate);
            c0428a.b(dVarIt);
        }
        int iV = dVarIt.v(c0428a);
        d(c0428a.getAdTemplate(), iV);
        return iV;
    }

    public static void d(AdTemplate adTemplate, int i) {
        switch (i) {
            case 0:
                com.kwad.sdk.commercial.convert.a.bW(adTemplate);
                break;
            case 1:
                com.kwad.sdk.commercial.convert.a.bL(adTemplate);
                break;
            case 2:
                com.kwad.sdk.commercial.convert.a.bV(adTemplate);
                break;
            case 3:
                com.kwad.sdk.commercial.convert.a.bN(adTemplate);
                break;
            case 4:
                com.kwad.sdk.commercial.convert.a.bT(adTemplate);
                break;
            case 5:
                com.kwad.sdk.commercial.convert.a.bU(adTemplate);
                break;
            case 6:
                com.kwad.sdk.commercial.convert.a.bO(adTemplate);
                break;
            case 7:
                com.kwad.sdk.commercial.convert.a.bP(adTemplate);
                break;
            case 8:
                com.kwad.sdk.commercial.convert.a.bQ(adTemplate);
                break;
            case 9:
                com.kwad.sdk.commercial.convert.a.bS(adTemplate);
                break;
            case 10:
                com.kwad.sdk.commercial.convert.a.bR(adTemplate);
                break;
            case 11:
                com.kwad.sdk.commercial.convert.a.bK(adTemplate);
                break;
            case 12:
                com.kwad.sdk.commercial.convert.a.bJ(adTemplate);
                break;
            case 13:
                com.kwad.sdk.commercial.convert.a.bI(adTemplate);
                break;
            case 14:
                com.kwad.sdk.commercial.convert.a.bH(adTemplate);
                break;
            case 15:
                com.kwad.sdk.commercial.convert.a.bM(adTemplate);
                break;
            case 16:
                com.kwad.sdk.commercial.convert.a.bY(adTemplate);
                break;
            case 17:
                com.kwad.sdk.commercial.convert.a.cb(adTemplate);
                break;
            case 18:
                com.kwad.sdk.commercial.convert.a.bX(adTemplate);
                break;
            case 19:
                com.kwad.sdk.commercial.convert.a.bZ(adTemplate);
                break;
            case 20:
                com.kwad.sdk.commercial.convert.a.ca(adTemplate);
                break;
        }
    }

    private static int n(C0428a c0428a) {
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (j(c0428a)) {
            return 11;
        }
        if (com.kwad.sdk.core.response.helper.a.b(adInfoEM, com.kwad.sdk.core.config.e.JU()) && !adTemplate.mAdWebVideoPageShowing) {
            return k(c0428a);
        }
        return l(c0428a);
    }

    /* JADX INFO: renamed from: com.kwad.components.core.e.d.a$a, reason: collision with other inner class name */
    public static class C0428a {
        private boolean QC;
        private boolean QD;
        private boolean QE;
        private boolean QF;
        private boolean QG;
        private boolean QH;
        private boolean QI;
        private b QJ;
        private d QK;
        private boolean QL;
        private boolean QM;
        private long QN;
        private boolean QO;
        public String QQ;
        public com.kwad.sdk.core.adlog.a.C0502a QR;
        private JSONObject QU;
        private boolean QW;
        private int QX;
        private int QY;
        private int QZ;
        private int Ra;
        private Callable<String> Rb;
        private String Rc;
        private boolean Rd;
        private boolean Re;
        private AdTemplate adTemplate;
        private final Context context;
        private int nc;
        private int ne;
        private boolean needReport;
        public al.a ng;
        public long zN;
        public int QP = -1;
        public int QS = 0;
        public int QT = -1;
        private boolean QV = false;

        public C0428a(Context context) {
            this.context = context;
        }

        public final String pM() {
            return this.Rc;
        }

        public final C0428a an(String str) {
            this.Rc = str;
            return this;
        }

        public final C0428a a(Callable<String> callable) {
            this.Rb = callable;
            return this;
        }

        public final Callable<String> pN() {
            return this.Rb;
        }

        public final Context getContext() {
            return this.context;
        }

        public final void ao(boolean z) {
            this.QM = true;
        }

        public final boolean pO() {
            return this.QM;
        }

        public final void aA(int i) {
            this.QY = i;
        }

        public final int pP() {
            return this.QY;
        }

        public final AdTemplate getAdTemplate() {
            return this.adTemplate;
        }

        public final C0428a aF(AdTemplate adTemplate) {
            this.adTemplate = adTemplate;
            return this;
        }

        public final b pQ() {
            return this.QJ;
        }

        public final boolean pR() {
            return this.QG;
        }

        public final C0428a a(b bVar) {
            this.QJ = bVar;
            return this;
        }

        public final int pS() {
            return this.Ra;
        }

        public final C0428a aB(int i) {
            this.Ra = i;
            return this;
        }

        public final C0428a aC(int i) {
            this.ne = i;
            return this;
        }

        public final int ee() {
            return this.ne;
        }

        public final C0428a ap(boolean z) {
            this.QH = z;
            return this;
        }

        public final boolean pT() {
            return this.QH;
        }

        public final d it() {
            return this.QK;
        }

        public final C0428a b(d dVar) {
            this.QK = dVar;
            return this;
        }

        public final C0428a aq(boolean z) {
            this.QI = true;
            return this;
        }

        public final boolean pU() {
            return this.QI;
        }

        public final C0428a ar(boolean z) {
            this.QG = true;
            return this;
        }

        public final boolean pV() {
            return this.QL;
        }

        public final C0428a as(boolean z) {
            this.QL = z;
            return this;
        }

        public final long pW() {
            return this.QN;
        }

        public final C0428a A(long j) {
            this.QN = j;
            return this;
        }

        public final boolean pX() {
            return this.QO;
        }

        public final C0428a at(boolean z) {
            this.QO = z;
            return this;
        }

        public final int eb() {
            return this.nc;
        }

        public final C0428a aD(int i) {
            this.nc = i;
            return this;
        }

        public final boolean pY() {
            return this.needReport;
        }

        public final C0428a au(boolean z) {
            this.needReport = z;
            return this;
        }

        public final com.kwad.sdk.core.adlog.c.a pZ() {
            return com.kwad.sdk.core.adlog.c.a.Jr().dM(this.ne).dZ(this.QQ).e(this.ng).dN(this.QS).dO(this.QT).ax(this.zN).a(this.QR).dP(this.QP);
        }

        public final C0428a ao(String str) {
            this.QQ = str;
            return this;
        }

        public final C0428a aE(int i) {
            this.QS = i;
            return this;
        }

        public final C0428a aF(int i) {
            this.QT = i;
            return this;
        }

        public final C0428a B(long j) {
            this.zN = j;
            return this;
        }

        public final C0428a d(al.a aVar) {
            this.ng = aVar;
            return this;
        }

        public final C0428a a(String str, String str2, com.kwad.sdk.g.a<AdTrackLog> aVar) {
            if (this.QR == null) {
                this.QR = new com.kwad.sdk.core.adlog.a.C0502a();
            }
            this.QR.a(this.adTemplate, null, null, null);
            return this;
        }

        public final boolean qa() {
            return this.QV;
        }

        public final C0428a av(boolean z) {
            this.QV = z;
            return this;
        }

        public final JSONObject iI() {
            return this.QU;
        }

        public final C0428a d(JSONObject jSONObject) {
            this.QU = jSONObject;
            return this;
        }

        public final boolean qb() {
            return this.QD;
        }

        public final C0428a aw(boolean z) {
            this.QD = z;
            return this;
        }

        public final boolean qc() {
            return this.QF;
        }

        public final C0428a ax(boolean z) {
            this.QF = true;
            return this;
        }

        public final boolean qd() {
            return this.QC;
        }

        public final C0428a ay(boolean z) {
            this.QC = z;
            return this;
        }

        public final boolean qe() {
            return this.QW;
        }

        public final C0428a az(boolean z) {
            this.QW = z;
            return this;
        }

        public final int qf() {
            return this.QX;
        }

        public final C0428a aG(int i) {
            this.QX = i;
            return this;
        }

        public final int qg() {
            return this.QZ;
        }

        public final C0428a aH(int i) {
            this.QZ = i;
            return this;
        }

        public final boolean qh() {
            return this.QE;
        }

        public final C0428a aA(boolean z) {
            this.QE = true;
            return this;
        }

        public final boolean qi() {
            return this.Rd;
        }

        public final void aB(boolean z) {
            this.Rd = true;
        }

        public final boolean qj() {
            return this.Re;
        }

        public final void aC(boolean z) {
            this.Re = true;
        }
    }
}
