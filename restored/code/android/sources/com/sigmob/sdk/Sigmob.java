package com.sigmob.sdk;

import android.content.Context;
import android.util.Base64;
import cn.thinkingdata.core.router.TRouterMap;
import com.alipay.sdk.app.AlipayApi;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.Constants;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.exceptions.CrashHandler;
import com.czhj.sdk.common.models.BidRequest;
import com.czhj.sdk.common.mta.PointEntitySuper;
import com.czhj.sdk.common.network.BuriedPointRequest;
import com.czhj.sdk.common.network.JsonRequest;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.track.AdTracker;
import com.czhj.sdk.common.track.TrackManager;
import com.czhj.sdk.common.utils.FileUtil;
import com.czhj.sdk.common.utils.ImageManager;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.VolleyError;
import com.czhj.volley.VolleyLog;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.h;
import com.sigmob.sdk.base.i;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointEntitySigmobCrash;
import com.sigmob.sdk.base.mta.PointInitEntity;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.services.f;
import com.sigmob.sdk.base.utils.n;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdOptions;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.WindCustomController;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.net.URLEncoder;
import java.util.Map;
import java.util.zip.DeflaterOutputStream;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class Sigmob {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Sigmob f3107a;
    public static SigMacroCommon macroCommon;
    private WindAdError b;

    private Sigmob() {
    }

    private String a(byte[] str) {
        if (str == null || str.length == 0) {
            return null;
        }
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        DeflaterOutputStream deflaterOutputStream = new DeflaterOutputStream(byteArrayOutputStream);
        try {
            deflaterOutputStream.write(str);
            deflaterOutputStream.flush();
            deflaterOutputStream.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return Base64.encodeToString(byteArrayOutputStream.toByteArray(), 2);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a() {
        h.b();
        h.l();
        h.j();
        h.i();
        h.h();
        h.k();
        h.c();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(int i, boolean z, boolean z2, int i2, boolean z3, Object obj) {
        if (obj instanceof PointInitEntity) {
            PointInitEntity pointInitEntity = (PointInitEntity) obj;
            Map<String, String> options = pointInitEntity.getOptions();
            options.put(PointParamKey.IS_MINOR, i.a().d() ? "0" : "1");
            options.put(PointParamKey.IS_UNPERSONALIZED, i.a().e() ? "0" : "1");
            options.put("canUseAppList", String.valueOf(i));
            options.put("appListPermission", z ? "1" : "0");
            options.put("disableUpAppInfo", z2 ? "1" : "0");
            options.put("EnableAppList", String.valueOf(i2));
            options.put("uploadAppList", z3 ? "1" : "0");
            options.put("common_version", String.valueOf(WindAds.sharedAds().getCommonVersion()));
            pointInitEntity.setOptions(options);
        }
    }

    private void a(final File file, String crash) {
        PointEntitySigmobCrash pointEntitySigmobCrashWindCrash = PointEntitySigmobCrash.WindCrash(crash);
        if (file != null) {
            try {
                pointEntitySigmobCrashWindCrash.setCrashTime(Long.parseLong(file.getName().replace(".log", "")));
            } catch (Throwable th) {
                SigmobLog.e("set crash time fail", th);
            }
        }
        pointEntitySigmobCrashWindCrash.sendServe(new BuriedPointRequest.RequestListener() { // from class: com.sigmob.sdk.Sigmob.3
            @Override // com.czhj.sdk.common.network.BuriedPointRequest.RequestListener
            public void onErrorResponse(VolleyError error) {
            }

            @Override // com.czhj.sdk.common.network.BuriedPointRequest.RequestListener
            public void onSuccess() {
                File file2 = file;
                if (file2 == null) {
                    return;
                }
                file2.delete();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(Object obj) {
        if (obj instanceof PointEntitySigmob) {
            ((PointEntitySigmob) obj).setPermission(ClientMetadata.getInstance().getPermission(b.e()));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, String str2) {
        if (s.b(str2)) {
            if (str2.contains(str) || str2.contains("com.czhj.")) {
                JSONObject jSONObject = new JSONObject();
                try {
                    jSONObject.put("crashTime", System.currentTimeMillis());
                    jSONObject.put(AlipayApi.c, WindAds.sharedAds().getAppId());
                    jSONObject.put("sdkVersion", WindAds.getVersion());
                    jSONObject.put("commonVersion", WindAds.sharedAds().getCommonVersion());
                    jSONObject.put("wmsession_id", PointEntitySuper.getSessionId());
                    jSONObject.put("crashLog", URLEncoder.encode(str2, "UTF-8"));
                    String string = jSONObject.toString();
                    SigmobLog.e("crashLog " + string);
                    File fileJ = n.j();
                    if (fileJ != null) {
                        FileUtil.writeToBuffer(string.getBytes(), fileJ.getAbsolutePath());
                    }
                    a(fileJ, string);
                } catch (Throwable th) {
                    SigmobLog.e("error ", th);
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(boolean z) {
        if (z) {
            com.sigmob.sdk.base.services.b.b();
            b();
            com.sigmob.sdk.base.services.b.d();
        }
    }

    private static void b() {
        try {
            f.a(f.b, true);
        } catch (Throwable th) {
            SigmobLog.e("initAppInstallService fail", th);
        }
    }

    private static void c() {
        try {
            f.a(f.c, i.a().i() && o.a().T());
        } catch (Throwable th) {
            SigmobLog.e("updateWifiScanService fail", th);
        }
    }

    public static BidRequest createRequest() {
        BidRequest.Builder builder = new BidRequest.Builder();
        try {
            builder = com.sigmob.sdk.base.network.a.a((LoadAdRequest) null);
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
        return builder.build();
    }

    private static void d() {
        try {
            f.a(f.d, true);
        } catch (Throwable th) {
            SigmobLog.e("initDownloadService fail", th);
        }
    }

    private void e() {
        Networking.getSigRequestQueue().add(new JsonRequest(o.d(), new JsonRequest.Listener() { // from class: com.sigmob.sdk.Sigmob.2
            @Override // com.czhj.volley.Response.ErrorListener
            public void onErrorResponse(VolleyError error) {
                Sigmob.this.g();
                i.a().a(null);
            }

            @Override // com.czhj.sdk.common.network.JsonRequest.Listener
            public void onSuccess(JSONObject response) {
                if (response != null) {
                    try {
                        i.a().a(Boolean.valueOf(response.getBoolean(Constants.IS_REQUEST_IN_EEA_OR_UNKNOWN)));
                    } catch (Throwable th) {
                        th.printStackTrace();
                    }
                }
                Sigmob.this.g();
            }
        }, 0));
    }

    private void f() {
        try {
            File[] fileArrK = n.k();
            if (fileArrK == null) {
                return;
            }
            for (File file : fileArrK) {
                String fileToString = FileUtil.readFileToString(file);
                if (!s.a((CharSequence) fileToString)) {
                    a(file, fileToString);
                }
            }
        } catch (Throwable th) {
            SigmobLog.e("send crash Log fail", th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void g() {
        d();
        b.d();
        o.a().a(new o.a() { // from class: com.sigmob.sdk.Sigmob$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.o.a
            public final void onUpdate(boolean z) {
                Sigmob.a(z);
            }
        }).f();
        if (o.a().X()) {
            String[] strArrSplit = WindAds.class.getName().split("\\.");
            if (strArrSplit.length <= 2) {
                return;
            }
            final String str = strArrSplit[0] + TRouterMap.DOT + strArrSplit[1] + TRouterMap.DOT;
            CrashHandler.getInstance().add(new CrashHandler.CrashHandlerListener() { // from class: com.sigmob.sdk.Sigmob$$ExternalSyntheticLambda1
                @Override // com.czhj.sdk.common.exceptions.CrashHandler.CrashHandlerListener
                public final void reportCrash(String str2) {
                    this.f$0.a(str, str2);
                }
            });
            f();
        }
        h();
    }

    public static synchronized Sigmob getInstance() {
        if (f3107a == null) {
            synchronized (Sigmob.class) {
                f3107a = new Sigmob();
            }
        }
        return f3107a;
    }

    private void h() {
        Context contextE = b.e();
        if (contextE == null) {
            return;
        }
        ImageManager.with(contextE).clearCache();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void i() {
        ad.a(PointCategory.APP);
        this.b = com.sigmob.sdk.base.common.f.b();
        e();
    }

    public static void updateLocationMonitor() {
        try {
            if (o.a().P()) {
                return;
            }
            f.a(f.f3248a, i.a().i());
        } catch (Throwable th) {
            SigmobLog.e("updateLocationMonitor fail", th);
        }
    }

    public SigMacroCommon getMacroCommon() {
        if (macroCommon == null) {
            macroCommon = new SigMacroCommon();
        }
        return macroCommon;
    }

    public String getSDKToken() {
        b.a(true);
        String str = "2.01|" + a(createRequest().encode());
        ad.a("token_request", (String) null, (BaseAdUnit) null, (ad.a) null);
        SigmobLog.d("getSDKToken: " + str);
        return str;
    }

    public WindAdError getSigMobError() {
        return this.b;
    }

    public void init() {
        int i;
        boolean zIsCanUseAppList;
        boolean z;
        WindCustomController customController;
        VolleyLog.DEBUG = com.sigmob.sdk.base.n.f.booleanValue();
        WindAdOptions options = WindAds.sharedAds().getOptions();
        o oVarA = o.a();
        final int iAb = oVarA.ab();
        boolean zJ = oVarA.j();
        final boolean zQ = oVarA.Q();
        boolean z2 = false;
        if (options == null || (customController = options.getCustomController()) == null) {
            i = 0;
            zIsCanUseAppList = true;
        } else {
            zIsCanUseAppList = customController.isCanUseAppList();
            i = zIsCanUseAppList ? 1 : 2;
        }
        if (zJ) {
            z = z2;
        } else if (iAb != 1) {
            if (iAb != 2 && zIsCanUseAppList && !zQ) {
                z2 = true;
            }
            z = z2;
        } else {
            z = true;
        }
        final boolean zD = com.sigmob.sdk.base.common.f.d();
        final int i2 = i;
        final boolean z3 = z;
        ad.a("init", new ad.a() { // from class: com.sigmob.sdk.Sigmob$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                Sigmob.a(i2, zD, zQ, iAb, z3, obj);
            }
        });
        if (o.a().V()) {
            ad.a(PointCategory.PERMISSION, "init", (BaseAdUnit) null, new ad.a() { // from class: com.sigmob.sdk.Sigmob$$ExternalSyntheticLambda3
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    Sigmob.a(obj);
                }
            });
        }
        h.e();
        ThreadPoolFactory.BackgroundThreadPool.getInstance().submit(new Runnable() { // from class: com.sigmob.sdk.Sigmob$$ExternalSyntheticLambda4
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.i();
            }
        });
        TrackManager.getInstance().setSigmobTrackListener(new TrackManager.Listener() { // from class: com.sigmob.sdk.Sigmob.1
            @Override // com.czhj.sdk.common.track.TrackManager.Listener
            public void onErrorResponse(AdTracker tracker, VolleyError error) {
                ad.a(tracker, tracker.getUrl(), (BaseAdUnit) null, error);
            }

            @Override // com.czhj.sdk.common.track.TrackManager.Listener
            public void onSuccess(AdTracker tracker, NetworkResponse response) {
                ad.a(tracker, tracker.getUrl(), (BaseAdUnit) null, response, (ad.a) null);
            }
        });
        ThreadPoolFactory.BackgroundThreadPool.getInstance().submit(new Runnable() { // from class: com.sigmob.sdk.Sigmob$$ExternalSyntheticLambda5
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a();
            }
        });
        TrackManager.getInstance().startRetryTracking();
    }
}
