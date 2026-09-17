package com.kwad.components.core.e.d;

import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Build;
import android.os.Handler;
import android.os.Looper;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.Log;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.page.AdWebViewVideoActivityProxy;
import com.kwad.components.core.page.DownloadLandPageActivity;
import com.kwad.sdk.api.KsApkDownloadListener;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.NetworkMonitor;
import com.kwad.sdk.core.diskcache.ApkCacheManager;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.ag;
import com.kwad.sdk.utils.an;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import com.kwad.sdk.utils.v;
import com.kwad.sdk.wrapper.m;
import java.io.File;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d implements NetworkMonitor.a, com.kwad.sdk.core.download.c, com.kwad.sdk.core.webview.a {
    private AdTemplate Rf;
    private boolean Rg;
    private a Rh;
    private DialogInterface.OnShowListener Ri;
    private List<KsAppDownloadListener> Rj;
    private boolean downloadPauseEnable;
    private Handler jc;
    private AdInfo mAdInfo;
    private DialogInterface.OnDismissListener mOnDismissListener;
    private JSONObject mReportExtData;

    public interface a {
        boolean handleDownloadDialog(DialogInterface.OnClickListener onClickListener);
    }

    public d(AdTemplate adTemplate, JSONObject jSONObject, KsAppDownloadListener ksAppDownloadListener) {
        this.jc = new Handler(Looper.getMainLooper());
        this.Rj = new ArrayList();
        this.Rf = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.mReportExtData = jSONObject;
        if (ksAppDownloadListener != null) {
            b(ksAppDownloadListener);
        }
        ql();
        this.downloadPauseEnable = com.kwad.sdk.core.response.helper.a.cO(com.kwad.sdk.core.response.helper.e.eM(this.Rf));
        qk();
        com.kwad.sdk.a.a.c.Hx().br(this.Rf);
    }

    public final void qk() {
        com.kwad.sdk.core.download.b.LK().a(this, this.Rf);
        if (com.kwad.sdk.core.config.e.Kn()) {
            NetworkMonitor.getInstance().a(ServiceProvider.getContext(), this, this.Rf);
        }
    }

    private void ql() {
        com.kwad.sdk.core.download.b.LK();
        int iEw = com.kwad.sdk.core.download.b.ew(qn());
        if (iEw != 0) {
            this.mAdInfo.status = iEw;
        }
        qr();
        qq();
    }

    public final void aI(int i) {
        this.Rf.downloadSource = i;
    }

    public final void e(JSONObject jSONObject) {
        this.mReportExtData = jSONObject;
    }

    public final int qm() {
        qr();
        if (this.mAdInfo.status == 3) {
            return 2;
        }
        return this.mAdInfo.status;
    }

    public d(AdTemplate adTemplate, KsAppDownloadListener ksAppDownloadListener) {
        this(adTemplate, null, ksAppDownloadListener);
    }

    public d(AdTemplate adTemplate, JSONObject jSONObject) {
        this(adTemplate, jSONObject, null);
    }

    public d(AdTemplate adTemplate) {
        this(adTemplate, null, null);
    }

    public d(AdTemplate adTemplate, KsAppDownloadListener ksAppDownloadListener, String str, String str2) {
        this(adTemplate, null, null);
        this.mAdInfo.adConversionInfo.appDownloadUrl = str;
        this.mAdInfo.adBaseInfo.appPackageName = str2;
        this.mAdInfo.downloadId = an.md5(str);
    }

    @Override // com.kwad.sdk.core.download.c
    public final String qn() {
        return this.mAdInfo.downloadId;
    }

    @Override // com.kwad.sdk.core.download.c
    public final String qo() {
        return this.mAdInfo.adBaseInfo.appPackageName;
    }

    @Override // com.kwad.sdk.core.download.c
    public final void a(String str, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            this.mAdInfo.status = 1;
            qq();
            if (eVar.LO()) {
                this.mAdInfo.mStartDownloadTime = SystemClock.elapsedRealtime();
                com.kwad.sdk.core.adlog.c.ck(this.Rf);
                eVar.LN();
                com.kwad.sdk.commercial.a.a.x(this.Rf);
            }
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void a(String str, int i, int i2, int i3) {
        if (this.mAdInfo.downloadId.equals(str)) {
            this.mAdInfo.status = 3;
            this.mAdInfo.progress = i;
            this.mAdInfo.soFarBytes = i2;
            this.mAdInfo.totalBytes = i3;
            qq();
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void a(String str, String str2, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            this.mAdInfo.downloadFilePath = str2;
            this.mAdInfo.progress = 100;
            this.mAdInfo.status = 8;
            qq();
            if (eVar.LO()) {
                eVar.LN();
                com.kwad.sdk.core.adlog.c.c(this.Rf, this.mReportExtData);
                com.kwad.sdk.commercial.a.a.k(this.Rf, SystemClock.elapsedRealtime() - this.mAdInfo.mStartDownloadTime);
                com.kwad.sdk.core.a.IT().e(str, this.Rf);
                i.execute(new Runnable() { // from class: com.kwad.components.core.e.d.d.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
                    }
                });
                com.kwad.sdk.a.a.c.Hx().bt(this.Rf);
                com.kwad.sdk.a.a.c.Hx().br(this.Rf);
                com.kwad.sdk.a.a.b.Hu().bm(this.Rf);
                ApkCacheManager.getInstance().Lx();
            }
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void a(String str, int i, String str2, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            this.mAdInfo.status = 7;
            qq();
            if (eVar.LO()) {
                com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a(i, str2);
                com.kwad.sdk.core.adlog.c.a(this.Rf, aVar);
                com.kwad.components.core.p.a.vX().a(this.Rf, this.mAdInfo.adConversionInfo.appDownloadUrl, aVar.toJson().toString());
                eVar.LN();
                com.kwad.sdk.commercial.a.a.i(this.Rf, i, str2);
            }
            if (this.mAdInfo.adConversionInfo.retryH5TimeStep <= 0 || this.Rg || SystemClock.elapsedRealtime() - this.mAdInfo.mStartDownloadTime >= this.mAdInfo.adConversionInfo.retryH5TimeStep || TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aY(this.mAdInfo))) {
                return;
            }
            AdWebViewActivityProxy.launch(ServiceProvider.getContext(), this.Rf);
            this.Rg = true;
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void b(String str, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            if (this.mAdInfo.status != 4 && eVar.LO()) {
                com.kwad.sdk.core.adlog.c.a(this.Rf, this.mReportExtData);
                eVar.LN();
                com.kwad.sdk.commercial.a.a.by(this.Rf);
            }
            this.mAdInfo.status = 4;
            qq();
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void c(String str, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            Integer num = com.kwad.sdk.core.download.b.aRY.get(str);
            if (num != null && num.intValue() == 2) {
                this.Rf.downLoadType = 2;
                com.kwad.sdk.core.download.b.aRY.remove(str);
            }
            if (this.mAdInfo.status != 2 && eVar.LO()) {
                com.kwad.sdk.core.adlog.c.b(this.Rf, this.mReportExtData);
                eVar.LN();
                com.kwad.sdk.commercial.a.a.bz(this.Rf);
            }
            this.mAdInfo.status = 2;
            qq();
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void d(String str, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            if (this.mAdInfo.status != 5 && eVar.LO()) {
                com.kwad.sdk.core.adlog.c.d(this.Rf, this.mReportExtData);
                eVar.LN();
                com.kwad.sdk.commercial.a.a.bA(this.Rf);
            }
            com.kwad.sdk.a.a.c.Hx().bs(this.Rf);
            com.kwad.sdk.a.a.b.Hu().bn(this.Rf);
            this.mAdInfo.status = 5;
            qq();
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void e(String str, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            this.mAdInfo.status = 9;
            qq();
            if (eVar.LO()) {
                com.kwad.sdk.core.adlog.c.k(this.Rf, 2);
                eVar.LN();
                com.kwad.sdk.commercial.a.a.bC(this.Rf);
            }
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void b(String str, String str2, com.kwad.sdk.core.download.e eVar) {
        final boolean zQp;
        this.mAdInfo.status = 12;
        qq();
        if (eVar.LO()) {
            com.kwad.sdk.core.adlog.c.e(this.Rf, this.mReportExtData);
            eVar.LN();
            com.kwad.sdk.commercial.a.a.bD(this.Rf);
            zQp = qp();
            com.kwad.sdk.a.a.c.Hx().bu(this.Rf);
            com.kwad.sdk.a.a.c.Hx().bs(this.Rf);
            com.kwad.sdk.a.a.b.Hu().bn(this.Rf);
            com.kwad.components.core.e.a.e.pt().aA(this.Rf);
            com.kwad.sdk.core.a.IT().dT(qn());
        } else {
            zQp = false;
        }
        i.execute(new bi() { // from class: com.kwad.components.core.e.d.d.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
            }
        });
    }

    @Override // com.kwad.sdk.core.download.c
    public final void f(String str, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            qr();
            if (eVar.LO()) {
                eVar.LN();
                com.kwad.sdk.commercial.a.a.bE(this.Rf);
            }
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void a(String str, Throwable th, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str)) {
            this.mAdInfo.status = 11;
            qq();
            if (eVar.LO()) {
                eVar.LN();
                com.kwad.sdk.commercial.a.a.j(this.Rf, 100003, Log.getStackTraceString(th));
            }
        }
    }

    @Override // com.kwad.sdk.core.download.c
    public final void g(String str, com.kwad.sdk.core.download.e eVar) {
        if (this.mAdInfo.downloadId.equals(str) && eVar.LO()) {
            eVar.LN();
            com.kwad.sdk.core.adlog.c.cl(this.Rf);
            com.kwad.sdk.commercial.a.a.bB(this.Rf);
        }
    }

    private boolean qp() {
        boolean zQv = false;
        if (Build.VERSION.SDK_INT < 29) {
            if (this.Rf.mIsFromContent && com.kwad.sdk.core.config.e.Jv()) {
                zQv = qv();
                if (zQv) {
                    com.kwad.sdk.core.adlog.c.cn(this.Rf);
                }
            } else if (!this.Rf.mIsFromContent && com.kwad.sdk.core.config.e.Kb()) {
                boolean zAz = com.kwad.components.core.m.b.az(ServiceProvider.getContext());
                com.kwad.sdk.core.d.c.d("ApkDownloadHelper", "handleForceOpenApp enableForceOpen: " + zAz);
                zQv = zAz ? qv() : false;
                if (zQv) {
                    com.kwad.sdk.core.adlog.c.co(this.Rf);
                }
            }
        }
        return zQv;
    }

    private void qq() {
        this.jc.post(new bi() { // from class: com.kwad.components.core.e.d.d.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ArrayList<KsAppDownloadListener> arrayList = new ArrayList(d.this.Rj.size());
                arrayList.addAll(d.this.Rj);
                for (KsAppDownloadListener ksAppDownloadListener : arrayList) {
                    if (ksAppDownloadListener != null) {
                        d.this.a(ksAppDownloadListener);
                    }
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(KsAppDownloadListener ksAppDownloadListener) {
        int iGv = com.kwad.sdk.core.config.e.Gv();
        boolean zGu = com.kwad.sdk.core.config.e.Gu();
        com.kwad.sdk.core.d.c.d("ApkDownloadHelper", "DownloadProgressTransformUtil  go in updateDownloadProgress");
        int iA = v.a(this.mAdInfo.soFarBytes, this.mAdInfo.totalBytes, zGu, iGv);
        switch (this.mAdInfo.status) {
            case 0:
            case 5:
                ksAppDownloadListener.onIdle();
                break;
            case 1:
                ksAppDownloadListener.onProgressUpdate(0);
                if (ksAppDownloadListener instanceof com.kwad.sdk.core.download.a.a) {
                    ((com.kwad.sdk.core.download.a.a) ksAppDownloadListener).onDownloadStarted();
                } else {
                    try {
                        ksAppDownloadListener.onDownloadStarted();
                    } catch (Throwable th) {
                        com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                        return;
                    }
                }
                break;
            case 2:
            case 3:
                ksAppDownloadListener.onProgressUpdate(iA);
                break;
            case 4:
                if (ksAppDownloadListener instanceof com.kwad.sdk.core.download.a.a) {
                    ((com.kwad.sdk.core.download.a.a) ksAppDownloadListener).onPaused(iA);
                }
                try {
                    if (ksAppDownloadListener instanceof KsApkDownloadListener) {
                        ((KsApkDownloadListener) ksAppDownloadListener).onPaused(iA);
                    }
                } catch (Throwable unused) {
                    return;
                }
                break;
            case 7:
                ksAppDownloadListener.onDownloadFailed();
                break;
            case 8:
            case 9:
                ksAppDownloadListener.onDownloadFinished();
                break;
            case 12:
                ksAppDownloadListener.onInstalled();
                break;
        }
    }

    public final void qr() {
        if (au.ax(ServiceProvider.getContext(), this.mAdInfo.adBaseInfo.appPackageName)) {
            this.mAdInfo.status = 12;
            return;
        }
        if (this.mAdInfo.status == 12) {
            this.mAdInfo.status = 0;
            this.mAdInfo.progress = 0;
        }
        if (this.mAdInfo.status == 8 || this.mAdInfo.status == 9) {
            String str = this.mAdInfo.downloadFilePath;
            if (TextUtils.isEmpty(str) || !new File(str).exists()) {
                this.mAdInfo.status = 0;
                this.mAdInfo.progress = 0;
            }
        }
        if (this.mAdInfo.status == 0) {
            String strJ = com.kwad.sdk.core.download.a.J(this.mAdInfo);
            if (TextUtils.isEmpty(strJ) || !new File(strJ).exists()) {
                return;
            }
            this.mAdInfo.downloadFilePath = strJ;
            this.mAdInfo.status = 8;
        }
    }

    public final int u(com.kwad.components.core.e.d.a.C0428a c0428a) {
        int i = this.mAdInfo.status;
        if (i != 0 && i != 1) {
            switch (i) {
                case 4:
                case 5:
                case 6:
                case 7:
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                    return qw();
                case 12:
                    return D(c0428a);
                default:
                    return 0;
            }
        }
        return x(c0428a) ? 11 : 0;
    }

    /* JADX WARN: Can't fix incorrect switch cases order, some code will duplicate */
    public final int v(com.kwad.components.core.e.d.a.C0428a c0428a) {
        this.Rg = false;
        qr();
        switch (this.mAdInfo.status) {
            case 0:
            case 1:
            case 5:
            case 6:
            case 7:
                return y(c0428a);
            case 2:
            case 3:
                if (c0428a.pV() && this.downloadPauseEnable) {
                    return qy();
                }
                return 0;
            case 4:
                return qz();
            case 8:
            case 9:
            case 11:
                return qw();
            case 10:
            default:
                return 0;
            case 12:
                return D(c0428a);
        }
    }

    public final AdTemplate qs() {
        return this.Rf;
    }

    public final boolean w(com.kwad.components.core.e.d.a.C0428a c0428a) {
        return this.mAdInfo.status == 0 && x(c0428a);
    }

    private boolean x(com.kwad.components.core.e.d.a.C0428a c0428a) {
        boolean zL = com.kwad.sdk.utils.f.l(c0428a.getContext(), this.Rf);
        if (zL) {
            com.kwad.sdk.core.adlog.c.n(this.Rf, 0);
        }
        return zL;
    }

    private int y(com.kwad.components.core.e.d.a.C0428a c0428a) {
        Context context = c0428a.getContext();
        if (com.kwad.sdk.utils.f.a(context, com.kwad.sdk.core.response.helper.a.dd(this.mAdInfo), this.Rf)) {
            com.kwad.sdk.core.adlog.c.n(this.Rf, 1);
            return 11;
        }
        if (x(c0428a)) {
            return 11;
        }
        if (qt()) {
            return 10;
        }
        if (!aq.isNetworkConnected(context)) {
            ae.V(context, ag.dk(context));
            return 2;
        }
        if (c0428a.qe() && com.kwad.sdk.core.config.e.JN()) {
            return z(c0428a);
        }
        if (com.kwad.sdk.core.response.helper.e.fb(this.Rf) && c0428a.qg() != 2) {
            return d(c0428a.getContext(), c0428a.getAdTemplate());
        }
        if (c0428a.qa()) {
            return A(c0428a);
        }
        if (B(c0428a)) {
            return 8;
        }
        return qx();
    }

    private int z(com.kwad.components.core.e.d.a.C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        int iQf = c0428a.qf();
        if (iQf == 1) {
            return qx();
        }
        if (iQf != 2) {
            return 1;
        }
        if (!com.kwad.sdk.core.response.helper.b.dL(adTemplate)) {
            return 8;
        }
        com.kwad.components.core.e.c.b.a(context, new com.kwad.components.core.e.c.b.a().aD(adTemplate).am(com.kwad.sdk.core.response.helper.b.dK(adTemplate)).a(this.Ri).c(this.mOnDismissListener).pI());
        return 8;
    }

    private int A(com.kwad.components.core.e.d.a.C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        int iE = E(c0428a);
        if (iE == 1) {
            if (com.kwad.sdk.core.response.helper.b.dL(adTemplate)) {
                com.kwad.components.core.e.c.b.a(context, new com.kwad.components.core.e.c.b.a().aD(adTemplate).am(com.kwad.sdk.core.response.helper.b.dK(adTemplate)).a(this.Ri).c(this.mOnDismissListener).pI());
            }
            return 8;
        }
        if (iE == 2) {
            return d(c0428a.getContext(), c0428a.getAdTemplate());
        }
        if (iE == 3) {
            return 1;
        }
        if (B(c0428a)) {
            return 8;
        }
        return qx();
    }

    private boolean B(com.kwad.components.core.e.d.a.C0428a c0428a) {
        if (c0428a.pX() || this.mAdInfo.status == 4 || !com.kwad.sdk.core.response.helper.b.dO(this.Rf) || !C(c0428a)) {
            return false;
        }
        return com.kwad.components.core.e.c.b.a(c0428a.getContext(), new com.kwad.components.core.e.c.b.a().aD(this.Rf).am(com.kwad.sdk.core.response.helper.b.dN(this.Rf)).a(this.Ri).c(this.mOnDismissListener).pI());
    }

    private static boolean C(com.kwad.components.core.e.d.a.C0428a c0428a) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(c0428a.getAdTemplate());
        if (com.kwad.sdk.core.response.helper.a.bC(adInfoEM) && (DownloadLandPageActivity.showingAdWebViewLandPage || AdWebViewVideoActivityProxy.showingAdWebViewVideoActivity || c0428a.getAdTemplate().isWebViewDownload)) {
            return true;
        }
        return com.kwad.sdk.core.response.helper.a.bD(adInfoEM) && !aq.isWifiConnected(c0428a.getContext());
    }

    private boolean qt() {
        a aVar = this.Rh;
        if (aVar != null) {
            return aVar.handleDownloadDialog(new DialogInterface.OnClickListener() { // from class: com.kwad.components.core.e.d.d.4
                @Override // android.content.DialogInterface.OnClickListener
                public final void onClick(DialogInterface dialogInterface, int i) {
                    if (i == -1) {
                        switch (d.this.mAdInfo.status) {
                            case 0:
                            case 1:
                            case 5:
                            case 6:
                            case 7:
                                d.this.qx();
                                break;
                            case 4:
                                d.this.qz();
                                break;
                            case 8:
                            case 9:
                            case 11:
                                d.this.qw();
                                break;
                            case 12:
                                d.this.qu();
                                break;
                        }
                    }
                }
            });
        }
        return false;
    }

    private int D(com.kwad.components.core.e.d.a.C0428a c0428a) {
        Activity activityFromContext = m.getActivityFromContext(c0428a.getContext());
        if (activityFromContext != null && com.kwad.sdk.core.response.helper.a.W(this.mAdInfo) && !c0428a.pO() && !c0428a.pT()) {
            c0428a.aA(1);
            com.kwad.components.core.e.e.e.a(activityFromContext, c0428a);
            return 18;
        }
        return qu();
    }

    public final int qu() {
        i.execute(new bi() { // from class: com.kwad.components.core.e.d.d.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
            }
        });
        if (!au.az(ServiceProvider.getContext(), com.kwad.sdk.core.response.helper.a.aE(this.mAdInfo))) {
            return 6;
        }
        com.kwad.sdk.core.adlog.c.cm(this.Rf);
        return 6;
    }

    private boolean qv() {
        Context context = ServiceProvider.getContext();
        if (e.a(new com.kwad.components.core.e.d.a.C0428a(context).aF(this.Rf), 1) == 1) {
            return true;
        }
        boolean zAz = au.az(context, com.kwad.sdk.core.response.helper.a.aE(this.mAdInfo));
        if (zAz) {
            com.kwad.sdk.core.adlog.c.cm(this.Rf);
        }
        return zAz;
    }

    public final int qw() {
        au.a(this.mAdInfo.downloadFilePath, new au.a() { // from class: com.kwad.components.core.e.d.d.6
            @Override // com.kwad.sdk.utils.au.a
            public final void qC() {
                com.kwad.sdk.core.adlog.c.k(d.this.Rf, 1);
                com.kwad.sdk.commercial.a.a.bC(d.this.Rf);
            }

            @Override // com.kwad.sdk.utils.au.a
            public final void d(Throwable th) {
                com.kwad.sdk.commercial.a.a.j(d.this.Rf, 100003, Log.getStackTraceString(th));
            }
        });
        return 7;
    }

    public final int qx() {
        com.kwad.sdk.core.download.a.K(this.mAdInfo);
        return 3;
    }

    public final int qy() {
        com.kwad.sdk.core.download.a.et(this.mAdInfo.downloadId);
        return 4;
    }

    public final int qz() {
        this.Rf.downLoadType = 2;
        qx();
        return 5;
    }

    private int qA() {
        this.Rf.downLoadType = 1;
        qx();
        return 5;
    }

    public final void b(final KsAppDownloadListener ksAppDownloadListener) {
        if (ksAppDownloadListener == null) {
            return;
        }
        if (Looper.myLooper() == Looper.getMainLooper()) {
            if (!this.Rj.contains(ksAppDownloadListener)) {
                this.Rj.add(0, ksAppDownloadListener);
            }
        } else {
            this.jc.post(new bi() { // from class: com.kwad.components.core.e.d.d.7
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (d.this.Rj.contains(ksAppDownloadListener)) {
                        return;
                    }
                    d.this.Rj.add(0, ksAppDownloadListener);
                }
            });
        }
        qr();
        a(ksAppDownloadListener);
    }

    public final void c(final KsAppDownloadListener ksAppDownloadListener) {
        if (ksAppDownloadListener == null) {
            return;
        }
        if (Looper.myLooper() == Looper.getMainLooper()) {
            this.Rj.remove(ksAppDownloadListener);
        } else {
            this.jc.post(new bi() { // from class: com.kwad.components.core.e.d.d.8
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    d.this.Rj.remove(ksAppDownloadListener);
                }
            });
        }
    }

    public final void d(KsAppDownloadListener ksAppDownloadListener) {
        if (ksAppDownloadListener == null) {
            return;
        }
        qr();
        a(ksAppDownloadListener);
    }

    public static int E(com.kwad.components.core.e.d.a.C0428a c0428a) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(c0428a.getAdTemplate());
        if (adInfoEM.downloadSafeInfo.complianceInfo == null) {
            return 0;
        }
        int iEb = c0428a.eb();
        if (iEb == 2) {
            return adInfoEM.downloadSafeInfo.complianceInfo.describeBarType;
        }
        if (iEb == 3) {
            return adInfoEM.downloadSafeInfo.complianceInfo.materialJumpType;
        }
        return adInfoEM.downloadSafeInfo.complianceInfo.actionBarType;
    }

    private static int d(Context context, AdTemplate adTemplate) {
        if (context == null || adTemplate == null) {
            return 9;
        }
        DownloadLandPageActivity.launch(context, adTemplate, false);
        return 9;
    }

    public final void clear() {
        qB();
    }

    @Override // com.kwad.sdk.core.webview.a
    public final void qB() {
        List<KsAppDownloadListener> list = this.Rj;
        if (list != null) {
            list.clear();
        }
    }

    public final void a(a aVar) {
        this.Rh = aVar;
    }

    public final void setOnShowListener(DialogInterface.OnShowListener onShowListener) {
        this.Ri = onShowListener;
    }

    public final void setOnDismissListener(DialogInterface.OnDismissListener onDismissListener) {
        this.mOnDismissListener = onDismissListener;
    }

    @Override // com.kwad.sdk.core.NetworkMonitor.a
    public final void a(NetworkMonitor.NetworkState networkState) {
        if (this.mAdInfo.status == 7 && networkState == NetworkMonitor.NetworkState.NETWORK_WIFI) {
            qA();
        }
    }
}
