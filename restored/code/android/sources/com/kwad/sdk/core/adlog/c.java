package com.kwad.sdk.core.adlog;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.api.model.AdExposureFailedReason;
import com.kwad.sdk.core.report.h;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bi;
import com.sigmob.sdk.base.mta.PointType;
import java.util.concurrent.ExecutorService;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static ExecutorService aLI = GlobalThreadPools.Ol();
    public static JSONObject aLJ;
    public static boolean aLK;

    public static void a(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.a aVar, JSONObject jSONObject) {
        if (aVar != null) {
            try {
                if (adTemplate.fromCache) {
                    aVar.a(h.cD(adTemplate));
                }
                aVar.e(adTemplate, null, null);
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
                return;
            }
        }
        a(adTemplate, 2, aVar, jSONObject);
    }

    @Deprecated
    public static void a(AdTemplate adTemplate, int i, al.a aVar) {
        com.kwad.sdk.core.adlog.c.a aVar2 = new com.kwad.sdk.core.adlog.c.a();
        aVar2.ne = i;
        if (adTemplate.swipeAngle != 0) {
            aVar2.aMR = adTemplate.swipeAngle;
        }
        if (aVar != null) {
            aVar2.ng = aVar;
        }
        a(adTemplate, aVar2, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.b bVar, JSONObject jSONObject) {
        a(adTemplate, bVar != null ? bVar.Jt() : null, jSONObject);
    }

    public static boolean b(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.sdk.core.adlog.c.b bVar) {
        if (adTemplate.mPvReported) {
            return false;
        }
        adTemplate.mPvReported = true;
        AdInfo adInfoEM = e.eM(adTemplate);
        if (bVar == null) {
            bVar = new com.kwad.sdk.core.adlog.c.b();
        }
        bVar.eg(Jf());
        com.kwad.sdk.core.adlog.c.a aVarJt = bVar.Jt();
        if (adTemplate.fromCache) {
            aVarJt.a(h.cD(adTemplate));
        }
        aVarJt.aMI = I(adInfoEM) ? 1 : 0;
        return a(adTemplate, 1, aVarJt, jSONObject);
    }

    private static int Jf() {
        return as.isOrientationPortrait() ? 2 : 1;
    }

    private static boolean I(AdInfo adInfo) {
        f fVar = (f) ServiceProvider.get(f.class);
        if (fVar == null) {
            return false;
        }
        String strAE = com.kwad.sdk.core.response.helper.a.aE(adInfo);
        if (TextUtils.isEmpty(strAE)) {
            return false;
        }
        return au.aw(fVar.getContext(), strAE);
    }

    public static void a(AdTemplate adTemplate, long j, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        if (j != -1) {
            c0502a.duration = j;
            aVar.QR = c0502a;
        }
        a(adTemplate, 934, aVar, (JSONObject) null);
    }

    @Deprecated
    public static void a(AdTemplate adTemplate, int i, long j, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMh = i;
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.duration = j;
        aVar.QR = c0502a;
        a(adTemplate, 3, aVar, jSONObject);
    }

    public static void b(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.b bVar, JSONObject jSONObject) {
        a(adTemplate, 3, bVar != null ? bVar.Jt() : null, jSONObject);
    }

    public static void a(AdTemplate adTemplate, int i, long j, int i2, long j2, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.zN = j;
        aVar.aMK = i2;
        aVar.aMh = i;
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.duration = j2;
        aVar.QR = c0502a;
        a(adTemplate, 3, aVar, (JSONObject) null);
    }

    public static void cj(AdTemplate adTemplate) {
        v(adTemplate, 4);
    }

    public static void ck(AdTemplate adTemplate) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.downloadSource = adTemplate.downloadSource;
        adTemplate.downLoadType = 3;
        aVar.a(new com.kwad.sdk.core.adlog.a.C0502a());
        aVar.QR.aLm = adTemplate.downLoadType;
        a(adTemplate, 30, aVar, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.downloadSource = adTemplate.downloadSource;
        aVar.a(new com.kwad.sdk.core.adlog.a.C0502a());
        aVar.QR.aLm = adTemplate.downLoadType;
        a(adTemplate, 33, aVar, jSONObject);
    }

    public static void b(AdTemplate adTemplate, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.downloadSource = adTemplate.downloadSource;
        aVar.a(new com.kwad.sdk.core.adlog.a.C0502a());
        aVar.QR.aLm = adTemplate.downLoadType;
        a(adTemplate, 34, aVar, jSONObject);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.b bVar) {
        AdInfo adInfoEM = e.eM(adTemplate);
        String str = adInfoEM.downloadFilePath;
        if (str == null) {
            return;
        }
        String strAE = com.kwad.sdk.core.response.helper.a.aE(adInfoEM);
        String strHV = au.hV(str);
        if (strHV == null || TextUtils.isEmpty(strHV) || strHV.equals(strAE)) {
            return;
        }
        bVar.ec(strHV);
        bVar.eb(strAE);
        adInfoEM.adBaseInfo.appPackageName = strHV;
    }

    public static void c(final AdTemplate adTemplate, final JSONObject jSONObject) {
        aLI.submit(new bi() { // from class: com.kwad.sdk.core.adlog.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                c0502a.aLm = adTemplate.downLoadType;
                com.kwad.sdk.core.adlog.c.b bVarDV = new com.kwad.sdk.core.adlog.c.b().b(c0502a).dV(adTemplate.downloadSource);
                c.a(adTemplate, bVarDV);
                c.a(adTemplate, 31, bVarDV.Jt(), jSONObject);
                AdInfo adInfoEM = e.eM(adTemplate);
                au.az(adInfoEM.downloadFilePath, adInfoEM.downloadId);
            }
        });
    }

    public static void d(AdTemplate adTemplate, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.downloadSource = adTemplate.downloadSource;
        aVar.a(new com.kwad.sdk.core.adlog.a.C0502a());
        aVar.QR.aLm = adTemplate.downLoadType;
        a(adTemplate, 35, aVar, jSONObject);
    }

    public static void e(final AdTemplate adTemplate, final JSONObject jSONObject) {
        aLI.submit(new bi() { // from class: com.kwad.sdk.core.adlog.c.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                AdInfo adInfoEM = e.eM(adTemplate);
                int iAA = au.aA(adInfoEM.downloadId, com.kwad.sdk.core.response.helper.a.aE(adInfoEM));
                com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
                aVar.downloadSource = adTemplate.downloadSource;
                aVar.aMw = iAA;
                aVar.aMx = adTemplate.installFrom;
                aVar.a(new com.kwad.sdk.core.adlog.a.C0502a());
                aVar.QR.aLm = adTemplate.downLoadType;
                c.a(adTemplate, 32, aVar, jSONObject);
            }
        });
    }

    public static void cl(AdTemplate adTemplate) {
        v(adTemplate, 36);
    }

    public static void cm(AdTemplate adTemplate) {
        v(adTemplate, 38);
    }

    public static void cn(AdTemplate adTemplate) {
        v(adTemplate, 41);
    }

    public static void co(AdTemplate adTemplate) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMB = com.kwad.sdk.core.response.helper.a.aE(e.eM(adTemplate));
        a(adTemplate, 768, aVar, new JSONObject());
    }

    public static void k(AdTemplate adTemplate, int i) {
        adTemplate.mInstallApkFromSDK = true;
        adTemplate.mInstallApkFormUser = i == 1;
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMN = i;
        aVar.a(new com.kwad.sdk.core.adlog.a.C0502a());
        aVar.QR.aLm = adTemplate.downLoadType;
        a(adTemplate, 37, aVar, (JSONObject) null);
    }

    public static void l(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.QS = i;
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_QUIC_READ_BLOCK_MODE, aVar, (JSONObject) null);
    }

    public static class a extends com.kwad.sdk.core.response.a.a {
        public int code;
        public String msg;

        public a(int i, String str) {
            this.code = i;
            this.msg = str;
        }
    }

    public static void a(AdTemplate adTemplate, a aVar) {
        com.kwad.sdk.core.adlog.c.a aVar2 = new com.kwad.sdk.core.adlog.c.a();
        aVar2.aMy = aVar.toJson().toString();
        aVar2.a(new com.kwad.sdk.core.adlog.a.C0502a());
        aVar2.QR.aLm = adTemplate.downLoadType;
        a(adTemplate, 40, aVar2, (JSONObject) null);
    }

    public static void f(AdTemplate adTemplate, JSONObject jSONObject) {
        d(adTemplate, 399, jSONObject);
    }

    public static void cp(AdTemplate adTemplate) {
        f(adTemplate, null);
    }

    public static void cq(AdTemplate adTemplate) {
        g(adTemplate, null);
    }

    public static void g(AdTemplate adTemplate, JSONObject jSONObject) {
        d(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_USE_CODEC_POOL, jSONObject);
    }

    public static void h(AdTemplate adTemplate, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMh = 1;
        aVar.QR = new com.kwad.sdk.core.adlog.a.C0502a();
        aVar.QR.templateId = PointType.ANTI_SPAM;
        a(adTemplate, 3, aVar, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, String str, int i, com.kwad.sdk.core.adlog.c.a aVar) {
        if (aVar == null) {
            aVar = new com.kwad.sdk.core.adlog.c.a();
        }
        aVar.aMt = i;
        if (!str.equals("")) {
            aVar.aMu = str;
        }
        a(adTemplate, 1038, aVar, (JSONObject) null);
    }

    public static void b(AdTemplate adTemplate, String str, int i, com.kwad.sdk.core.adlog.c.a aVar) {
        if (aVar == null) {
            aVar = new com.kwad.sdk.core.adlog.c.a();
        }
        aVar.aMt = i;
        if (!str.equals("")) {
            aVar.aMu = str;
        }
        a(adTemplate, 1039, aVar, (JSONObject) null);
    }

    public static void c(AdTemplate adTemplate, String str, int i, com.kwad.sdk.core.adlog.c.a aVar) {
        if (aVar == null) {
            aVar = new com.kwad.sdk.core.adlog.c.a();
        }
        aVar.aMt = i;
        if (!str.equals("")) {
            aVar.aMu = str;
        }
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_LAST_VIDEO_RENDER_TIME, aVar, (JSONObject) null);
    }

    public static void d(AdTemplate adTemplate, String str, int i, com.kwad.sdk.core.adlog.c.a aVar) {
        aVar.aMt = i;
        if (!str.equals("")) {
            aVar.aMu = str;
        }
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_RENDER_STALL_THRESHOLD, aVar, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, String str, int i) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMt = 1;
        if (!str.equals("")) {
            aVar.aMu = str;
        }
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_RTC_MAX_RECONNECT_COUNT, aVar, (JSONObject) null);
    }

    public static void d(AdTemplate adTemplate, String str, int i, int i2) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMt = i;
        if (aVar.QR == null) {
            aVar.QR = new com.kwad.sdk.core.adlog.a.C0502a();
        }
        aVar.QR.aLG = i2;
        if (!str.equals("")) {
            aVar.aMu = str;
        }
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_RTC_MAX_RECONNECT_COUNT, aVar, (JSONObject) null);
    }

    public static void m(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMv = i;
        d(adTemplate, "wxsmallapp", 1, aVar);
    }

    public static void n(AdTemplate adTemplate, int i) {
        h(adTemplate, i, 0);
    }

    public static void h(AdTemplate adTemplate, int i, int i2) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMH = i;
        aVar.QT = i2;
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_RENDER_STALL, aVar, (JSONObject) null);
    }

    public static void h(AdTemplate adTemplate, boolean z) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        if (z) {
            c0502a.aLq = 1;
        } else {
            c0502a.aLq = 2;
        }
        aVar.a(c0502a);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_RENDER_STALL, aVar, (JSONObject) null);
    }

    public static void i(AdTemplate adTemplate, boolean z) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        if (z) {
            c0502a.aLq = 1;
        } else {
            c0502a.aLq = 2;
        }
        aVar.a(c0502a);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SKIP_NULL_TAG, aVar, (JSONObject) null);
    }

    public static void cr(AdTemplate adTemplate) {
        v(adTemplate, 58);
    }

    public static void a(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.a aVar) {
        a(adTemplate, 50, aVar, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.a aVar, long j) {
        aVar.aMF = j;
        a(adTemplate, 51, aVar, (JSONObject) null);
    }

    public static void l(AdTemplate adTemplate, long j) {
        a(adTemplate, 52, com.kwad.sdk.core.adlog.c.a.Jr().ay(j), (JSONObject) null);
    }

    public static void b(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.a aVar, long j) {
        aVar.aMF = j;
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_LIVE_AVPH_VIDEO_DIFF_THRESHOLD, aVar, (JSONObject) null);
    }

    public static void b(AdTemplate adTemplate, com.kwad.sdk.core.adlog.c.a aVar) {
        a(adTemplate, 59, aVar, (JSONObject) null);
    }

    public static void i(AdTemplate adTemplate, JSONObject jSONObject) {
        d(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_SET_LIVE_PROTOCOL_HANDLE, jSONObject);
    }

    public static void i(AdTemplate adTemplate, int i, int i2) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMi = 69;
        aVar.aMD = i;
        aVar.aME = i2;
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_SET_LIVE_PROTOCOL_HANDLE, aVar, (JSONObject) null);
    }

    public static void j(AdTemplate adTemplate, JSONObject jSONObject) {
        d(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_CMAF_MPD_SOCKET_CONNECT_TIME, jSONObject);
    }

    public static void k(AdTemplate adTemplate, JSONObject jSONObject) {
        d(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_CMAF_MPD_PACKET_RECV_TIME, jSONObject);
    }

    public static void c(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.sdk.core.adlog.c.b bVar) {
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_CMAF_MPD_PACKET_RECV_TIME, bVar != null ? bVar.Jt() : null, (JSONObject) null);
    }

    public static void o(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMg = i;
        a(adTemplate, 759, aVar, (JSONObject) null);
    }

    public static void p(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMf = i;
        a(adTemplate, 28, aVar, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, int i, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMf = i;
        a(adTemplate, 402, aVar, jSONObject);
    }

    public static void cs(AdTemplate adTemplate) {
        v(adTemplate, 914);
    }

    @Deprecated
    public static void b(AdTemplate adTemplate, int i, JSONObject jSONObject) {
        d(adTemplate, jSONObject, new com.kwad.sdk.core.adlog.c.b().dU(i));
    }

    public static void d(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.sdk.core.adlog.c.b bVar) {
        if (bVar == null) {
            bVar = new com.kwad.sdk.core.adlog.c.b();
        }
        com.kwad.sdk.core.adlog.c.a aVarJt = bVar.Jt();
        aVarJt.e(adTemplate, null, null);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_CODEC_ID, aVarJt, jSONObject);
    }

    public static void q(AdTemplate adTemplate, int i) {
        if (adTemplate == null) {
            return;
        }
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMB = com.kwad.sdk.core.response.helper.a.aE(e.eM(adTemplate));
        a(adTemplate, i, aVar, new JSONObject());
    }

    public static void c(AdTemplate adTemplate, int i, JSONObject jSONObject) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMB = com.kwad.sdk.core.response.helper.a.aE(e.eM(adTemplate));
        aVar.aMi = 93;
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_CODEC_ID, aVar, (JSONObject) null);
    }

    public static void r(AdTemplate adTemplate, int i) {
        a(adTemplate, i, new com.kwad.sdk.core.adlog.c.a(), new JSONObject());
    }

    @Deprecated
    public static void s(AdTemplate adTemplate, int i) {
        e(adTemplate, null, new com.kwad.sdk.core.adlog.c.b().dU(i));
    }

    public static void e(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.sdk.core.adlog.c.b bVar) {
        if (bVar == null) {
            bVar = new com.kwad.sdk.core.adlog.c.b();
        }
        com.kwad.sdk.core.adlog.c.a aVarJt = bVar.Jt();
        aVarJt.e(adTemplate, null, null);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_CODEC_ID, aVarJt, jSONObject);
    }

    public static void m(AdTemplate adTemplate, long j) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMk = j;
        a(adTemplate, 600, aVar, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, int i, AdExposureFailedReason adExposureFailedReason) {
        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == -9999 || i == 6) {
            com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
            aVar.aMl = i;
            if (adExposureFailedReason != null) {
                aVar.aMm = adExposureFailedReason.winEcpm;
                try {
                    aVar.adnType = adExposureFailedReason.adnType;
                    if (adExposureFailedReason.adnType == 2) {
                        aVar.adnName = adExposureFailedReason.adnName;
                    }
                    if (!TextUtils.isEmpty(adExposureFailedReason.adUserName)) {
                        aVar.aMn = adExposureFailedReason.adUserName;
                    }
                    if (!TextUtils.isEmpty(adExposureFailedReason.adTitle)) {
                        aVar.aMo = adExposureFailedReason.adTitle;
                    }
                    if (!TextUtils.isEmpty(adExposureFailedReason.adRequestId)) {
                        aVar.aMp = adExposureFailedReason.adRequestId;
                    }
                    aVar.aMq = adExposureFailedReason.isShow;
                    aVar.aMr = adExposureFailedReason.isClick;
                    aVar.adnMaterialType = adExposureFailedReason.adnMaterialType;
                    aVar.adnMaterialUrl = adExposureFailedReason.adnMaterialUrl;
                } catch (Throwable unused) {
                }
            }
            a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_RTC_START_TIME, aVar, (JSONObject) null);
        }
    }

    public static void ct(AdTemplate adTemplate) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.downloadStatus = com.kwad.sdk.core.response.helper.a.bG(e.eM(adTemplate));
        com.kwad.sdk.core.d.c.d("AdReportManager", "reportDownloadCardClose downloadStatus=" + aVar.downloadStatus);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_LIVE_AVPH_READ_RETRY_COUNT, aVar, (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, int i, JSONObject jSONObject, String str) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.QQ = str;
        a(adTemplate, i, aVar, jSONObject);
    }

    public static void cu(AdTemplate adTemplate) {
        v(adTemplate, 722);
    }

    public static void cv(AdTemplate adTemplate) {
        v(adTemplate, 721);
    }

    public static void n(AdTemplate adTemplate, long j) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.aMG = j;
        a(adTemplate, 401, aVar, (JSONObject) null);
    }

    public static void j(AdTemplate adTemplate, boolean z) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLn = 1;
        bVar.b(c0502a);
        if (z) {
            bVar.eb(33);
        }
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_RTC_RECONNECT_INTERVAL, bVar.Jt(), (JSONObject) null);
    }

    public static void cw(AdTemplate adTemplate) {
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLx = com.kwad.sdk.core.response.helper.a.dG(e.eM(adTemplate)) ? 1 : 0;
        c0502a.aLE = 1;
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        bVar.b(c0502a);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_QUIC_VERSION, bVar.Jt(), (JSONObject) null);
    }

    public static void t(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLx = com.kwad.sdk.core.response.helper.a.dG(e.eM(adTemplate)) ? 1 : 0;
        c0502a.aLE = i;
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        bVar.b(c0502a);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_QUIC_VERSION, bVar.Jt(), (JSONObject) null);
    }

    public static void k(AdTemplate adTemplate, boolean z) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLn = 2;
        bVar.b(c0502a);
        if (z) {
            bVar.eb(33);
        }
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_RTC_RECONNECT_INTERVAL, bVar.Jt(), (JSONObject) null);
    }

    public static void u(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLC = i;
        bVar.b(c0502a);
        a(adTemplate, 1032, bVar.Jt(), (JSONObject) null);
    }

    public static void j(AdTemplate adTemplate, int i, int i2) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLC = i;
        c0502a.aLD = i2;
        bVar.b(c0502a);
        a(adTemplate, AVMDLDataLoader.KeyIsPreloadStragetyWhenPlay, bVar.Jt(), (JSONObject) null);
    }

    public static void k(AdTemplate adTemplate, int i, int i2) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLC = i;
        c0502a.aLD = i2;
        bVar.b(c0502a);
        a(adTemplate, 1033, bVar.Jt(), (JSONObject) null);
    }

    public static void cx(AdTemplate adTemplate) {
        a(adTemplate, 1031, (com.kwad.sdk.core.adlog.c.a) null, (JSONObject) null);
    }

    public static void l(AdTemplate adTemplate, boolean z) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLr = z;
        bVar.b(c0502a);
        a(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_DECODER_PRE_STALL_500, bVar.Jt(), (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, boolean z, int i) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLr = z;
        bVar.b(c0502a);
        bVar.eh(i);
        a(adTemplate, 935, bVar.Jt(), (JSONObject) null);
    }

    public static void a(AdTemplate adTemplate, String str, String str2, int i) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLx = com.kwad.sdk.core.response.helper.a.dG(e.eM(adTemplate)) ? 1 : 0;
        c0502a.aLz = str;
        c0502a.aLA = str2;
        c0502a.aLB = i;
        bVar.b(c0502a);
        a(adTemplate, 1024, bVar.Jt(), (JSONObject) null);
    }

    private static void v(AdTemplate adTemplate, int i) {
        a(adTemplate, i, (com.kwad.sdk.core.adlog.c.a) null, new JSONObject());
    }

    private static void d(AdTemplate adTemplate, int i, JSONObject jSONObject) {
        a(adTemplate, i, (com.kwad.sdk.core.adlog.c.a) null, jSONObject);
    }

    public static boolean a(AdTemplate adTemplate, int i, com.kwad.sdk.core.adlog.c.a aVar, JSONObject jSONObject) {
        if (adTemplate == null || !cy(adTemplate)) {
            return false;
        }
        if (aVar == null) {
            aVar = new com.kwad.sdk.core.adlog.c.a();
        }
        aVar.aMJ = com.kwad.sdk.core.response.helper.a.aZ(e.eM(adTemplate));
        aVar.adxResult = adTemplate.adxResult;
        if (i == 2 && aLK) {
            if (aVar.QR == null) {
                aVar.QR = new com.kwad.sdk.core.adlog.a.C0502a();
            }
            aVar.QR.aLt = aLJ;
        }
        if (i == 1 && e.eG(adTemplate) == 4 && com.kwad.sdk.core.response.helper.a.dC(e.eM(adTemplate))) {
            if (aVar.QR == null) {
                aVar.QR = new com.kwad.sdk.core.adlog.a.C0502a();
            }
            aVar.QR.aLs = com.kwad.sdk.core.response.helper.a.dD(e.eM(adTemplate));
        }
        if (i == 1 || i == 2) {
            if (aVar.QR == null) {
                aVar.QR = new com.kwad.sdk.core.adlog.a.C0502a();
            }
            aVar.QR.aLx = com.kwad.sdk.core.response.helper.a.dG(e.eM(adTemplate)) ? 1 : 0;
            if (AdTemplate.isInnerEcCancelDowngrade) {
                aVar.QR.aLy = 1;
            }
        }
        aVar.adTemplate = adTemplate;
        aVar.aKK = i;
        aVar.aMe = jSONObject;
        com.kwad.sdk.core.d.c.d("AdReportManager", new StringBuilder().append(i).toString());
        b.a(aVar);
        return true;
    }

    private static boolean cy(AdTemplate adTemplate) {
        if (e.eE(adTemplate)) {
            return true;
        }
        f fVar = (f) ServiceProvider.get(f.class);
        return fVar != null && fVar.bj(adTemplate);
    }
}
