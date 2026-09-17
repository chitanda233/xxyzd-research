package com.sigmob.sdk.base;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.models.Config;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.network.SigmobRequestQueue;
import com.czhj.sdk.common.track.TrackManager;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.VolleyError;
import com.czhj.wire.Wire;
import com.sigmob.sdk.base.models.config.SigmobAndroid;
import com.sigmob.sdk.base.models.config.SigmobCommon;
import com.sigmob.sdk.base.models.config.SigmobCommonEndpointsConfig;
import com.sigmob.sdk.base.models.config.SigmobDialogSetting;
import com.sigmob.sdk.base.models.config.SigmobNativeConfig;
import com.sigmob.sdk.base.models.config.SigmobRvConfig;
import com.sigmob.sdk.base.models.config.SigmobSdkConfig;
import com.sigmob.sdk.base.models.config.SigmobSdkConfigResponse;
import com.sigmob.sdk.base.models.config.SigmobSplashConfig;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.base.utils.y;
import com.sigmob.windad.WindAds;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class o {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static Boolean f3242a = null;
    private static final String b = "o";
    private static final String c = "sdkConfigVer";
    private static o d = null;
    private static final boolean e = false;
    private static String n = null;
    private static boolean o = false;
    private a m;
    private final String h = "4.25.14";
    private long j = 0;
    private SigmobSdkConfig k = null;
    private SigmobSdkConfig l = null;
    private final Handler f = new Handler(Looper.getMainLooper());
    private final Runnable g = new Runnable() { // from class: com.sigmob.sdk.base.o$$ExternalSyntheticLambda0
        @Override // java.lang.Runnable
        public final void run() {
            this.f$0.aj();
        }
    };
    private final boolean i = true;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.o$1, reason: invalid class name */
    class AnonymousClass1 implements com.sigmob.sdk.base.network.g.a {
        AnonymousClass1() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(SigmobSdkConfig sigmobSdkConfig) {
            o.this.a(sigmobSdkConfig, true);
        }

        @Override // com.sigmob.sdk.base.network.g.a
        public void a(SigmobSdkConfigResponse sdkConfigResponse) throws Throwable {
            boolean unused = o.o = false;
            SigmobLog.d(sdkConfigResponse.toString());
            final SigmobSdkConfig sigmobSdkConfig = sdkConfigResponse.config;
            if (sigmobSdkConfig == null) {
                SigmobLog.e(sdkConfigResponse.error_message);
            } else {
                WindAds.sharedAds().getHandler().post(new Runnable() { // from class: com.sigmob.sdk.base.o$1$$ExternalSyntheticLambda0
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.a(sigmobSdkConfig);
                    }
                });
                o.this.a(sigmobSdkConfig);
            }
            o.this.aq();
        }

        @Override // com.czhj.volley.Response.ErrorListener
        public void onErrorResponse(VolleyError error) {
            String unused = o.n = o.this.am();
            if (o.o) {
                o.this.aq();
            } else {
                boolean unused2 = o.o = true;
                o.this.f.post(o.this.g);
            }
            SigmobLog.e(error.toString());
        }
    }

    public interface a {
        void onUpdate(boolean isOnline);
    }

    private o() {
        ai();
    }

    public static synchronized o a() {
        if (d == null) {
            d = new o();
        }
        return d;
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:24:0x0063 -> B:32:0x006a). Please report as a decompilation issue!!! */
    public void a(SigmobSdkConfig sigmobSdkConfig) throws Throwable {
        if (sigmobSdkConfig == null) {
            return;
        }
        File file = new File(com.sigmob.sdk.base.utils.n.a() + "/config");
        if (file.exists()) {
            file.delete();
        }
        file.getParentFile().mkdirs();
        ObjectOutputStream objectOutputStream = null;
        try {
            try {
                try {
                    ObjectOutputStream objectOutputStream2 = new ObjectOutputStream(new FileOutputStream(file));
                    try {
                        sigmobSdkConfig.encode(objectOutputStream2);
                        y.b(com.sigmob.sdk.b.e(), (String) null, c, "4.25.14");
                        objectOutputStream2.close();
                    } catch (IOException e2) {
                        e = e2;
                        objectOutputStream = objectOutputStream2;
                        SigmobLog.e(e.getMessage());
                        if (objectOutputStream != null) {
                            objectOutputStream.close();
                        }
                    } catch (Throwable th) {
                        th = th;
                        objectOutputStream = objectOutputStream2;
                        if (objectOutputStream != null) {
                            try {
                                objectOutputStream.close();
                            } catch (IOException e3) {
                                SigmobLog.e(e3.getMessage());
                            }
                        }
                        throw th;
                    }
                } catch (Throwable th2) {
                    th = th2;
                }
            } catch (IOException e4) {
                e = e4;
            }
        } catch (IOException e5) {
            SigmobLog.e(e5.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(SigmobSdkConfig config, boolean isOnline) {
        if (config == null || config.sigmobCommon_config == null) {
            return;
        }
        Boolean bool = config.sigmobCommon_config.noncompliance_mark;
        if (v.b((Object) bool)) {
            f3242a = bool;
        }
        this.l = config;
        this.j = ((Integer) Wire.get(config.sigmobCommon_config.configRefresh, 1800)).intValue() * 1000;
        int iK = k();
        if (iK <= 0) {
            com.sigmob.sdk.manager.d.a().c();
        } else {
            com.sigmob.sdk.manager.d.a().a(iK);
        }
        SigmobLog.d("config: " + config);
        if (v.b(this.m)) {
            this.m.onUpdate(isOnline);
        }
        Config.sharedInstance().setEnable_okhttp3(Z());
        Config.sharedInstance().setNetworkTimeout(an());
        Config.sharedInstance().update(false, ac(), Y(), U(), r(), I(), H(), ak());
        TrackManager.getInstance().setRetryInterval(G());
        TrackManager.getInstance().setRetryExpiredTime(F());
    }

    private void ai() {
        if (this.k == null) {
            SigmobSdkConfig.Builder builder = new SigmobSdkConfig.Builder();
            SigmobCommon.Builder builder2 = new SigmobCommon.Builder();
            SigmobAndroid.Builder builder3 = new SigmobAndroid.Builder();
            SigmobCommonEndpointsConfig.Builder builder4 = new SigmobCommonEndpointsConfig.Builder();
            builder4.native_ad(a(false));
            builder2.endpoints(builder4.build());
            SigmobRvConfig.Builder builder5 = new SigmobRvConfig.Builder();
            builder5.cacheTop(4);
            builder2.rv_config(builder5.build());
            builder2.configRefresh(1000);
            builder2.disable_up_location(false);
            builder2.is_gdpr_region(false);
            builder2.enable_debug_level(false);
            builder3.disable_boot_mark(true);
            builder3.disableUpAppInfo(true);
            builder3.oaid_api_is_disable(true);
            builder3.enable_permission(false);
            builder3.enable_report_crash(false);
            builder.common_config(builder2.build());
            builder.android_config(builder3.build());
            this.k = builder.build();
        }
        SigmobLog.d("Default config: " + this.k);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aj() {
        if (com.sigmob.sdk.b.e() == null) {
            return;
        }
        if (ClientMetadata.getInstance().isNetworkConnected(c()) && i.a().i()) {
            al();
        } else {
            SigmobLog.d("Can't load an ad because there is no network connectivity.");
            aq();
        }
    }

    private boolean ak() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobCommonP.log_enc, false)).booleanValue();
    }

    private void al() {
        SigmobRequestQueue sigRequestQueue = Networking.getSigRequestQueue();
        com.sigmob.sdk.base.network.g gVar = new com.sigmob.sdk.base.network.g(c(), new AnonymousClass1());
        if (sigRequestQueue == null) {
            SigmobLog.e("queue is null");
            aq();
        } else {
            sigRequestQueue.add(gVar);
            SigmobLog.i("update sdk config");
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String am() {
        SigmobCommon sigmobCommonP = p();
        return (sigmobCommonP == null || sigmobCommonP.endpoints == null) ? "" : (String) Wire.get(sigmobCommonP.endpoints.config, "https://c.etoolads.cn/s/config");
    }

    private int an() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return 0;
        }
        return ((Integer) Wire.get(sigmobCommonP.network_timeout, 0)).intValue();
    }

    private boolean ao() {
        if (!v.b((Object) f3242a)) {
            SigmobCommon sigmobCommonP = p();
            if (sigmobCommonP == null) {
                return false;
            }
            f3242a = (Boolean) Wire.get(sigmobCommonP.noncompliance_mark, false);
            com.sigmob.sdk.base.utils.k.c(b, "noncomplianceMark(config) = " + f3242a, new Object[0]);
        }
        return f3242a.booleanValue();
    }

    private void ap() {
        this.f.removeCallbacks(this.g);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aq() {
        ap();
        if (this.i) {
            this.f.postDelayed(this.g, Math.max(30000L, this.j));
        }
    }

    private SigmobSplashConfig ar() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return null;
        }
        return sigmobCommonP.splash_config;
    }

    private SigmobNativeConfig as() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return null;
        }
        return sigmobCommonP.native_config;
    }

    public static String b() {
        return "appId=" + WindAds.sharedAds().getAppId() + "&sdkVersion=4.25.14";
    }

    public static String c() {
        StringBuilder sb;
        StringBuilder sbAppend;
        String str;
        if (s.b(n)) {
            if (n.indexOf(63) == -1) {
                sbAppend = new StringBuilder().append(n);
                str = "?";
            } else {
                sbAppend = new StringBuilder().append(n);
                str = com.alipay.sdk.m.w.a.p;
            }
            sb = sbAppend.append(str);
        } else {
            sb = s.b("https://adservice.sigmob.cn/s/config") ? new StringBuilder("https://adservice.sigmob.cn/s/config?") : new StringBuilder("https://adservice.sigmob.cn/s/config?");
        }
        return sb.append(b()).toString();
    }

    public static String d() {
        return "https://adservice.sigmob.cn/extconfig?" + b();
    }

    public static boolean n() {
        return false;
    }

    public long A() {
        SigmobNativeConfig sigmobNativeConfigAs = as();
        if (sigmobNativeConfigAs == null) {
            return 45000L;
        }
        int iIntValue = ((Integer) Wire.get(sigmobNativeConfigAs.ad_load_timeout, 45)).intValue();
        if (iIntValue < 10) {
            iIntValue = 10;
        }
        return ((long) iIntValue) * 1000;
    }

    public boolean B() {
        SigmobCommon sigmobCommonP = p();
        return (sigmobCommonP == null || sigmobCommonP.anti_fraud_log == null || sigmobCommonP.anti_fraud_log.events == null) ? false : true;
    }

    public int C() {
        SigmobCommon sigmobCommonP = p();
        if (!B() || sigmobCommonP.anti_fraud_log.motion_config == null) {
            return 0;
        }
        return ((Integer) Wire.get(sigmobCommonP.anti_fraud_log.motion_config.interval, 0)).intValue();
    }

    public int D() {
        if (!B() || p().anti_fraud_log.motion_config == null) {
            return 0;
        }
        return ((Integer) Wire.get(p().anti_fraud_log.motion_config.count, 0)).intValue();
    }

    public int E() {
        if (!B() || p().anti_fraud_log.motion_config == null) {
            return 0;
        }
        return p().anti_fraud_log.motion_config.queue_max.intValue() + (-50) < p().anti_fraud_log.motion_config.count.intValue() * 2 ? (((Integer) Wire.get(p().anti_fraud_log.motion_config.count, 0)).intValue() * 2) + 50 : ((Integer) Wire.get(p().anti_fraud_log.motion_config.queue_max, 0)).intValue();
    }

    public long F() {
        long jIntValue = p() != null ? ((Integer) Wire.get(p().tracking_expiration_time, 86400)).intValue() : 86400L;
        if (jIntValue < 180) {
            return 180L;
        }
        return jIntValue;
    }

    public int G() {
        int iIntValue = p() != null ? ((Integer) Wire.get(p().tracking_retry_interval, 180)).intValue() : 180;
        if (iIntValue < 10) {
            return 10;
        }
        return iIntValue;
    }

    public int H() {
        int iIntValue = SigmobCommon.DEFAULT_MAX_SEND_LOG_RECORDS.intValue();
        if (p() != null) {
            iIntValue = ((Integer) Wire.get(p().max_send_log_records, SigmobCommon.DEFAULT_MAX_SEND_LOG_RECORDS)).intValue();
        }
        return iIntValue < 10 ? SigmobCommon.DEFAULT_MAX_SEND_LOG_RECORDS.intValue() : iIntValue;
    }

    public int I() {
        int iIntValue;
        if (p() == null || (iIntValue = ((Integer) Wire.get(p().send_log_interval, 3)).intValue()) < 3) {
            return 3;
        }
        return iIntValue;
    }

    public boolean J() {
        SigmobAndroid sigmobAndroidQ;
        if (j() || (sigmobAndroidQ = q()) == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.enable_open_pkg_list, false)).booleanValue();
    }

    public boolean K() {
        SigmobAndroid sigmobAndroidQ;
        if (j() || (sigmobAndroidQ = q()) == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.enable_open_pkg_dir_list, false)).booleanValue();
    }

    public Boolean L() {
        o oVarA = a();
        return Boolean.valueOf(oVarA.J() || oVarA.K());
    }

    public List<Integer> M() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return null;
        }
        return sigmobCommonP.dclog_blacklist;
    }

    public boolean N() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobCommonP.enable_debug_level, false)).booleanValue();
    }

    public long O() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return 0L;
        }
        long jIntValue = ((Integer) Wire.get(sigmobCommonP.load_interval, 0)).intValue();
        if (jIntValue < 1) {
            return 0L;
        }
        return jIntValue * 1000;
    }

    public boolean P() {
        SigmobCommon sigmobCommonP;
        if (j() || (sigmobCommonP = p()) == null) {
            return true;
        }
        return ((Boolean) Wire.get(sigmobCommonP.disable_up_location, false)).booleanValue();
    }

    public boolean Q() {
        SigmobAndroid sigmobAndroidQ;
        if (j() || (sigmobAndroidQ = q()) == null) {
            return true;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.disableUpAppInfo, false)).booleanValue();
    }

    public int R() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return 0;
        }
        return ((Integer) Wire.get(sigmobAndroidQ.report_log, 0)).intValue();
    }

    public List<String> S() {
        SigmobAndroid sigmobAndroidQ = q();
        return sigmobAndroidQ == null ? new ArrayList() : sigmobAndroidQ.open_pkg_list;
    }

    public boolean T() {
        SigmobAndroid sigmobAndroidQ = q();
        return sigmobAndroidQ != null && ((Integer) Wire.get(sigmobAndroidQ.up_wifi_list_interval, 0)).intValue() >= 60;
    }

    public int U() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return 0;
        }
        return ((Integer) Wire.get(sigmobAndroidQ.disable_up_oaid, 0)).intValue();
    }

    public boolean V() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.enable_permission, false)).booleanValue();
    }

    public int W() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return 0;
        }
        return ((Integer) Wire.get(sigmobAndroidQ.apk_expired_time, 0)).intValue();
    }

    public boolean X() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.enable_report_crash, false)).booleanValue();
    }

    public boolean Y() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return true;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.oaid_api_is_disable, false)).booleanValue();
    }

    public boolean Z() {
        return false;
    }

    public o a(a onSDKUpdateListener) {
        this.m = onSDKUpdateListener;
        return d;
    }

    public String a(boolean saasAdx) {
        String str;
        StringBuilder sbAppend;
        String str2;
        String strConcat = "https://".concat(saasAdx ? n.V : n.S);
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null || sigmobCommonP.endpoints == null) {
            str = "";
        } else {
            str = saasAdx ? sigmobCommonP.endpoints.saas_ads : sigmobCommonP.endpoints.ads;
        }
        if (s.b(str)) {
            strConcat = str;
        }
        if (strConcat.indexOf(63) == -1) {
            sbAppend = new StringBuilder().append(strConcat);
            str2 = "?";
        } else {
            sbAppend = new StringBuilder().append(strConcat);
            str2 = com.alipay.sdk.m.w.a.p;
        }
        return sbAppend.append(str2).append(b()).toString();
    }

    public boolean a(String key) {
        SigmobCommon sigmobCommonP = p();
        if (!B() || sigmobCommonP.anti_fraud_log.events == null) {
            return false;
        }
        return sigmobCommonP.anti_fraud_log.events.contains(key);
    }

    public boolean aa() {
        SigmobAndroid sigmobAndroidQ;
        if (j() || (sigmobAndroidQ = q()) == null) {
            return true;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.disable_install_monitor, false)).booleanValue();
    }

    public int ab() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return 0;
        }
        return ((Integer) Wire.get(sigmobAndroidQ.enable_app_list, 0)).intValue();
    }

    public boolean ac() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return true;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.disable_boot_mark, false)).booleanValue();
    }

    public boolean ad() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.use_web_source_cache, false)).booleanValue();
    }

    public boolean ae() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobCommonP.enable_extra_dclog, false)).booleanValue();
    }

    public int af() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return 0;
        }
        return ((Integer) Wire.get(sigmobAndroidQ.web_source_cache_expiration_time, 0)).intValue();
    }

    public int ag() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return 500;
        }
        return ((Integer) Wire.get(sigmobAndroidQ.s2s_token_timeout, 500)).intValue();
    }

    public Boolean b(String packageName) {
        boolean zB;
        if (s.a((CharSequence) packageName)) {
            return false;
        }
        Context contextE = com.sigmob.sdk.b.e();
        boolean zJ = J();
        boolean zK = K();
        if (zJ) {
            zB = com.sigmob.sdk.base.utils.h.a(contextE, packageName);
        } else {
            if (!zK) {
                return false;
            }
            zB = com.sigmob.sdk.base.utils.h.b(contextE, packageName);
        }
        return Boolean.valueOf(zB);
    }

    public String b(boolean saasAdx) {
        String str;
        StringBuilder sbAppend;
        String str2;
        String strConcat = "https://".concat(saasAdx ? n.W : n.T);
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null || sigmobCommonP.endpoints == null) {
            str = "";
        } else {
            str = saasAdx ? sigmobCommonP.endpoints.saas_hb_ads : sigmobCommonP.endpoints.hb_ads;
        }
        if (s.b(str)) {
            strConcat = str;
        }
        if (strConcat.indexOf(63) == -1) {
            sbAppend = new StringBuilder().append(strConcat);
            str2 = "?";
        } else {
            sbAppend = new StringBuilder().append(strConcat);
            str2 = com.alipay.sdk.m.w.a.p;
        }
        return sbAppend.append(str2).append(b()).toString();
    }

    public String c(boolean saasAdx) {
        String str;
        StringBuilder sbAppend;
        String str2;
        String strConcat = "https://".concat(saasAdx ? n.V : n.S);
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null || sigmobCommonP.endpoints == null) {
            str = "";
        } else {
            str = saasAdx ? sigmobCommonP.endpoints.saas_native_ad : sigmobCommonP.endpoints.native_ad;
        }
        if (s.b(str)) {
            strConcat = str;
        }
        if (strConcat.indexOf(63) == -1) {
            sbAppend = new StringBuilder().append(strConcat);
            str2 = "?";
        } else {
            sbAppend = new StringBuilder().append(strConcat);
            str2 = com.alipay.sdk.m.w.a.p;
        }
        return sbAppend.append(str2).append(b()).toString();
    }

    public void e() {
        ObjectInputStream objectInputStream = null;
        String strA = y.a(com.sigmob.sdk.b.e(), (String) null, c, (String) null);
        File file = new File(com.sigmob.sdk.base.utils.n.a() + "/config");
        if ("4.25.14".equals(strA)) {
            try {
                if (file.exists()) {
                    try {
                        ObjectInputStream objectInputStream2 = new ObjectInputStream(new FileInputStream(file));
                        try {
                            a(SigmobSdkConfig.ADAPTER.decode(objectInputStream2), false);
                            objectInputStream2.close();
                        } catch (Throwable th) {
                            th = th;
                            objectInputStream = objectInputStream2;
                            try {
                                a(this.k, false);
                                SigmobLog.e(th.getMessage());
                                if (objectInputStream == null) {
                                    return;
                                } else {
                                    objectInputStream.close();
                                }
                            } catch (Throwable th2) {
                                if (objectInputStream != null) {
                                    try {
                                        objectInputStream.close();
                                    } catch (Throwable th3) {
                                        SigmobLog.e(th3.getMessage());
                                    }
                                }
                                throw th2;
                            }
                        }
                    } catch (Throwable th4) {
                        th = th4;
                    }
                    return;
                }
            } catch (Throwable th5) {
                SigmobLog.e(th5.getMessage());
                return;
            }
        }
        a(this.k, false);
    }

    public void f() {
        ap();
        this.f.post(this.g);
    }

    public boolean g() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobCommonP.feedback_debug, false)).booleanValue();
    }

    public boolean h() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.lock_play, false)).booleanValue();
    }

    public boolean i() {
        SigmobAndroid sigmobAndroidQ = q();
        if (sigmobAndroidQ == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobAndroidQ.screen_keep, false)).booleanValue();
    }

    public boolean j() {
        return !ao();
    }

    public int k() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return 0;
        }
        int iIntValue = ((Integer) Wire.get(sigmobCommonP.expire_monitor_interval, 0)).intValue();
        SigmobLog.d("expireMonitorInterval = " + iIntValue);
        return iIntValue;
    }

    public boolean l() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return false;
        }
        return ((Boolean) Wire.get(sigmobCommonP.enable_active_expire, false)).booleanValue();
    }

    public int m() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return 0;
        }
        Integer num = (Integer) Wire.get(sigmobCommonP.sniffing_type, 0);
        SigmobLog.d("sniffingType = " + num);
        return num.intValue();
    }

    public SigmobSdkConfig o() {
        SigmobSdkConfig sigmobSdkConfig = this.l;
        return sigmobSdkConfig == null ? this.k : sigmobSdkConfig;
    }

    public SigmobCommon p() {
        SigmobSdkConfig sigmobSdkConfigO = o();
        if (sigmobSdkConfigO == null) {
            return null;
        }
        return sigmobSdkConfigO.sigmobCommon_config;
    }

    public SigmobAndroid q() {
        SigmobSdkConfig sigmobSdkConfigO = o();
        if (sigmobSdkConfigO == null) {
            return null;
        }
        return sigmobSdkConfigO.sigmobAndroid_config;
    }

    public String r() {
        StringBuilder sbAppend;
        String str;
        SigmobCommon sigmobCommonP = p();
        String str2 = (sigmobCommonP == null || sigmobCommonP.endpoints == null) ? "" : sigmobCommonP.endpoints.log;
        if (!s.b(str2)) {
            str2 = "https://dc.sigmob.cn/log";
        }
        if (str2.indexOf(63) == -1) {
            sbAppend = new StringBuilder().append(str2);
            str = "?";
        } else {
            sbAppend = new StringBuilder().append(str2);
            str = com.alipay.sdk.m.w.a.p;
        }
        return sbAppend.append(str).append(b()).toString();
    }

    public String s() {
        StringBuilder sbAppend;
        String str;
        String str2 = (String) Wire.get(p().endpoints.feedback, "https://adxtool.sigmob.cn/debug/feedback");
        if (s.a((CharSequence) str2)) {
            return str2;
        }
        if (str2.indexOf(63) == -1) {
            sbAppend = new StringBuilder().append(str2);
            str = "?";
        } else {
            sbAppend = new StringBuilder().append(str2);
            str = com.alipay.sdk.m.w.a.p;
        }
        return sbAppend.append(str).append(b()).toString();
    }

    public SigmobRvConfig t() {
        SigmobCommon sigmobCommonP = p();
        if (sigmobCommonP == null) {
            return null;
        }
        return sigmobCommonP.rv_config;
    }

    public int u() {
        SigmobRvConfig sigmobRvConfigT = t();
        if (sigmobRvConfigT == null) {
            return 5;
        }
        return ((Integer) Wire.get(sigmobRvConfigT.cacheTop, 5)).intValue();
    }

    public long v() {
        SigmobRvConfig sigmobRvConfigT = t();
        if (sigmobRvConfigT == null) {
            return 45000L;
        }
        int iIntValue = ((Integer) Wire.get(sigmobRvConfigT.ad_load_timeout, 45)).intValue();
        if (iIntValue < 10) {
            iIntValue = 10;
        }
        return ((long) iIntValue) * 1000;
    }

    public SigmobDialogSetting w() {
        SigmobRvConfig sigmobRvConfigT = t();
        if (sigmobRvConfigT == null) {
            return null;
        }
        return sigmobRvConfigT.close_dialog_setting;
    }

    public int x() {
        SigmobSplashConfig sigmobSplashConfigAr = ar();
        if (sigmobSplashConfigAr == null) {
            return 50;
        }
        return ((Integer) Wire.get(sigmobSplashConfigAr.cacheTop, 50)).intValue();
    }

    public long y() {
        SigmobSplashConfig sigmobSplashConfigAr = ar();
        int iIntValue = sigmobSplashConfigAr != null ? ((Integer) Wire.get(sigmobSplashConfigAr.material_expired_time, 2)).intValue() : 2;
        return iIntValue < 0 ? iIntValue : ((long) iIntValue) * 24 * 60 * 60 * 1000;
    }

    public int z() {
        SigmobNativeConfig sigmobNativeConfigAs = as();
        if (sigmobNativeConfigAs == null) {
            return 50;
        }
        return ((Integer) Wire.get(sigmobNativeConfigAs.cacheTop, 50)).intValue();
    }
}
