package com.unicom.online.account.shield;

import android.content.Context;
import android.os.Build;
import android.text.TextUtils;
import android.util.Log;
import com.baidu.mobads.sdk.internal.bz;
import com.kwad.components.offline.api.tk.model.report.TKDownloadReason;
import com.unicom.online.account.kernel.an;
import com.unicom.online.account.kernel.ao;
import com.unicom.online.account.kernel.ap;
import com.unicom.online.account.kernel.aq;
import com.unicom.online.account.kernel.ar;
import com.unicom.online.account.kernel.as;
import com.unicom.online.account.kernel.au;
import com.unicom.online.account.kernel.av;
import com.unicom.online.account.kernel.be;
import com.unicom.online.account.kernel.bh;
import com.unicom.online.account.kernel.bi;
import com.unicom.online.account.kernel.bk;
import com.unicom.online.account.kernel.bl;
import com.unicom.online.account.kernel.bn;
import com.unicom.online.account.kernel.bp;
import com.unicom.online.account.kernel.c;
import com.unicom.online.account.kernel.e;
import com.unicom.online.account.kernel.i;
import com.unicom.online.account.kernel.l;
import com.unicom.online.account.kernel.v;
import java.lang.ref.WeakReference;
import java.util.concurrent.TimeUnit;
import org.bouncycastle.jce.provider.BouncyCastleProvider;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public class UniAccountHelper {
    private static final int CU_GET_TOKEN_GM = 3;
    private static final int CU_GET_TOKEN_IT = 2;
    private static final int CU_GET_TOKEN_LOOP = 32;
    private static final int CU_GET_UAID_LOOP = 33;
    private static final int CU_MOBILE_AUTH_GM = 5;
    private static final int CU_MOBILE_AUTH_IT = 4;
    private static final String FAKEMOBILEIMAGE = "fakeMobileImage";
    private static final String FAKEMOBILESTYLE = "fakeMobileStyle";
    private static final int ID_0_STOP_ONCE_SUCCESS = 0;
    private static final int ID_1_STOP_ALL_SEND = 1;
    private static final String StrcuPreGetToken = "_Token_";
    private static final boolean enableToken = true;
    private static final boolean enableUAID = false;
    private static final boolean enable_ReInit = false;
    private static volatile UniAccountHelper s_instance;

    private UniAccountHelper() {
    }

    private UniAccountHelper clearCache_one(int i) {
        if (l.c() == null) {
            System.currentTimeMillis();
            return null;
        }
        bp bpVarE = bp.e();
        Context contextC = l.c();
        bpVarE.getClass();
        String str = (i == 2 || i == 3 || i == 4 || i == 5) ? "T" + i : "";
        if (contextC != null) {
            be.b(contextC, "AC_" + str + "_Token__isOk_");
        }
        return s_instance;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cuGetTokenUaidLoopCommon(int i, int i2, int i3, ResultListener resultListener) {
        if (l.d == 0) {
            l.b();
        } else if (i != 1) {
            cuPreGetToken(i3, i2, StrcuPreGetToken, new bk(this, i2, i, i3, resultListener));
        } else {
            cuPreGetToken(i3, i2, StrcuPreGetToken, new bl(this, i2, i, i3, resultListener));
        }
    }

    /* JADX WARN: Code duplicated, block: B:150:0x00df A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:58:0x00d7  */
    /* JADX WARN: Code duplicated, block: B:66:0x00f4 A[Catch: Exception -> 0x0115, TryCatch #6 {Exception -> 0x0115, blocks: (B:61:0x00df, B:64:0x00ee, B:66:0x00f4, B:68:0x0102, B:70:0x010e), top: B:150:0x00df }] */
    /* JADX WARN: Unreachable blocks removed: 2, instructions: 3 */
    private void cuPreGetToken(int i, int i2, String str, ResultListener resultListener) {
        String str2;
        int i3;
        int i4;
        String string;
        Boolean bool;
        JSONObject jSONObject;
        int i5;
        if (l.c() == null) {
            initFail(i2, resultListener, "sdk未初始化:".concat(l.c() != null ? "" : "Context()==null"), i);
            return;
        }
        int iC = au.c(l.c());
        if (iC != 0 && iC != 1) {
            l.b(i2, resultListener, 410004, "数据网络未开启", i);
            return;
        }
        if (getUseCacheFlag()) {
            bp bpVarE = bp.e();
            Context contextC = l.c();
            bpVarE.getClass();
            if (str.equals(StrcuPreGetToken)) {
                String strConcat = str.concat("_isOk_");
                string = (i2 == 2 || i2 == 3 || i2 == 4 || i2 == 5) ? "T" + i2 : "";
                try {
                    String strB = c.b(0, contextC, string, strConcat);
                    try {
                        if (bh.c(strB).booleanValue()) {
                            str2 = "Context()==null";
                            i3 = 0;
                            try {
                                string = contextC.getSharedPreferences("cuAuthCacheName", 0).getString(strB, "");
                            } catch (Exception e) {
                                try {
                                    e.getMessage();
                                    string = "";
                                } catch (Exception unused) {
                                }
                            }
                        } else {
                            str2 = "Context()==null";
                            i3 = 0;
                        }
                    } catch (Exception unused2) {
                    }
                } catch (Exception unused3) {
                    str2 = "Context()==null";
                    i3 = 0;
                }
                if (string != null || string.length() == 0 || string.trim().length() == 0 || "null".equals(string) || string.equals("")) {
                    bool = Boolean.FALSE;
                } else {
                    bool = Boolean.TRUE;
                }
                if (bool.booleanValue()) {
                    try {
                        jSONObject = new JSONObject(string);
                        i5 = jSONObject.getInt("resultCode");
                        try {
                            jSONObject.getInt("type");
                        } catch (Exception unused4) {
                        }
                        if (ap.b(2)) {
                            long j = jSONObject.getJSONObject("resultData").getLong("exp");
                            if (i5 == 100 && j > System.currentTimeMillis() + 5000) {
                                l.b();
                                resultListener.onResult(string);
                                return;
                            }
                        }
                    } catch (Exception unused5) {
                        l.b();
                    }
                }
            } else {
                str2 = "Context()==null";
                i3 = 0;
            }
            string = "";
            if (string != null) {
                bool = Boolean.FALSE;
            } else {
                bool = Boolean.FALSE;
            }
            if (bool.booleanValue()) {
                jSONObject = new JSONObject(string);
                i5 = jSONObject.getInt("resultCode");
                jSONObject.getInt("type");
                if (ap.b(2)) {
                    long j2 = jSONObject.getJSONObject("resultData").getLong("exp");
                    if (i5 == 100) {
                        l.b();
                        resultListener.onResult(string);
                        return;
                    }
                }
            }
        } else {
            str2 = "Context()==null";
            i3 = 0;
            if (ar.b) {
                Log.d("UniAccount", "6.3.3 CacheFlag is false");
            }
        }
        bp bpVarE2 = bp.e();
        Context contextC2 = l.c();
        bpVarE2.getClass();
        bp.e().getClass();
        be.b(contextC2, "success_limit_count", Long.valueOf(be.c(contextC2, "success_limit_count").longValue() + 1));
        Long lC = be.c(contextC2, "success_limit_time");
        long jCurrentTimeMillis = System.currentTimeMillis();
        if (jCurrentTimeMillis - lC.longValue() > 600000) {
            be.b(contextC2, "success_limit_time", Long.valueOf(jCurrentTimeMillis));
            be.b(contextC2, "success_limit_count", 0L);
        } else {
            Long lC2 = be.c(contextC2, "success_limit_count");
            if (!contextC2.getPackageName().equals(new String(aq.b("d28uYW5kcm9pZC5kZW1vLnRlc3Q="))) ? lC2.longValue() >= 50 : lC2.longValue() >= 500) {
                l.b(i2, resultListener, 410025, "操作频繁,请稍后再试", i);
                return;
            }
        }
        if (!str.equals(StrcuPreGetToken)) {
            initFail(i2, resultListener, "sdk参数错误", i);
            return;
        }
        if (i2 == 2 || i2 == 3) {
            i4 = 4;
        } else {
            i4 = 4;
            if (i2 != 4 && i2 != 5) {
                initFail(i2, resultListener, "sdk type 参数错误", i);
                return;
            }
        }
        l.b |= i4;
        bp bpVarE3 = bp.e();
        bn bnVar = new bn(this, i2, str, i, resultListener);
        bpVarE3.getClass();
        if (bp.b() == null || TextUtils.isEmpty(ap.j) || TextUtils.isEmpty(ao.c())) {
            String str3 = "sdk未初始化:" + ((bp.b() == null ? str2 : "").concat(TextUtils.isEmpty(ap.j) ? "AppId==null" : "") + (TextUtils.isEmpty(ao.c()) ? "AppSecret==null" : ""));
            String str4 = "type:" + i2 + "\nmsg:" + str3;
            Log.e("UniAccount", "6.3.3CR001B1208 " + str4);
            as.b(str4, i3);
            try {
                JSONObject jSONObject2 = new JSONObject();
                jSONObject2.put("resultCode", 1);
                jSONObject2.put("resultMsg", str3);
                jSONObject2.put("resultData", "");
                jSONObject2.put("seq", bp.c());
                bnVar.b(jSONObject2.toString());
                return;
            } catch (Exception e2) {
                as.b(e2);
                return;
            }
        }
        as.d = i3;
        as.e = i3;
        StringBuilder sb = as.g;
        sb.setLength(i3);
        sb.append("\n\n■★■★■★■★■★■★■★■★■★■\n\ncom debug info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        StringBuilder sb2 = as.f;
        sb2.setLength(i3);
        sb2.append("\n\n■★■★■★■★■★■★■★■★■★■\n\nall debug info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        StringBuilder sb3 = as.h;
        sb3.setLength(i3);
        sb3.append("\n\n■★■★■★■★■★■★■★■★■★■\n\nresult  info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        StringBuilder sb4 = as.i;
        sb4.setLength(i3);
        sb4.append("\n\n■★■★■★■★■★■★■★■★■★■\n\ncost time  info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        as.b("cuPreGetToken", i3);
        au.c = i3;
        au.b = i3;
        ao.u = i;
        i iVar = new i();
        Context contextB = bp.b();
        Thread.currentThread().getId();
        Thread.currentThread().getName();
        av avVar = new av();
        iVar.e = avVar;
        avVar.b = bnVar;
        bi biVarB = bi.b();
        biVarB.getClass();
        if (i <= 0) {
            biVarB.b = 500;
            biVarB.c = 1000;
            biVarB.d = 1500;
            biVarB.e = 1800;
        } else {
            double d = i / 3;
            int i6 = (int) (0.5d * d);
            int iMax = Math.max(500, i6);
            int iMax2 = Math.max(1000, i6);
            int i7 = (int) (d * 1.0d);
            int iMax3 = Math.max(1500, i7);
            int iMax4 = Math.max(1800, i7);
            biVarB.b = iMax;
            biVarB.c = iMax2;
            biVarB.d = iMax3;
            biVarB.e = iMax4;
        }
        try {
            iVar.b.schedule(new e(iVar, i2), i, TimeUnit.MILLISECONDS);
            iVar.c(contextB, i2);
        } catch (Exception e3) {
            as.b(e3);
        }
    }

    private String getHostName() {
        return bp.d();
    }

    public static UniAccountHelper getInstance() {
        if (s_instance == null) {
            synchronized (UniAccountHelper.class) {
                if (s_instance == null) {
                    s_instance = new UniAccountHelper();
                }
            }
        }
        return s_instance;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean getUseCacheFlag() {
        return ap.e;
    }

    private void initFail(int i, ResultListener resultListener, String str, int i2) {
        l.b(i, resultListener, 410021, str, i2);
    }

    private static void initialize(Context context) {
        if (l.e == null) {
            l.e = new WeakReference(context.getApplicationContext());
        }
    }

    public UniAccountHelper clearCache() {
        if (l.c() == null) {
            System.currentTimeMillis();
            return null;
        }
        bp bpVarE = bp.e();
        Context contextC = l.c();
        bpVarE.getClass();
        if (contextC != null) {
            be.b(contextC, "AC_");
        }
        return s_instance;
    }

    /* JADX WARN: Code duplicated, block: B:59:0x00d8  */
    public String cuDebugInfo(String str) {
        String packageName;
        if (l.c() == null) {
            return "sdk 未初始化, context 为空";
        }
        bp.e().getClass();
        if (bp.b() == null) {
            return "sdk 未初始化, context 为空";
        }
        try {
            switch (str.toLowerCase()) {
                case "apikey":
                case "appid":
                    packageName = ap.j;
                    return packageName;
                case "packagename":
                    if (bp.b() != null) {
                        packageName = bp.b().getApplicationContext().getPackageName();
                        return packageName;
                    }
                    return "context 为空";
                case "md5":
                case "sha1":
                case "sha256":
                    if (bp.b() != null) {
                        packageName = au.b(bp.b(), bp.b().getPackageName(), str.toLowerCase());
                        return packageName;
                    }
                    return "context 为空";
                case "sm3":
                    if (bp.b() != null) {
                        if (!ap.g) {
                            return "sdk 未初始化支持国密";
                        }
                        packageName = au.b(bp.b(), bp.b().getPackageName());
                        return packageName;
                    }
                    return "context 为空";
                case "bcproviderversion":
                    if (!ap.g) {
                        return "sdk 未初始化支持国密";
                    }
                    try {
                        packageName = String.valueOf(new BouncyCastleProvider());
                        break;
                    } catch (Exception unused) {
                        packageName = "Security.getProvider(BouncyCastleProvider.PROVIDER_NAME) is null";
                    }
                    return packageName;
                case "certfingertype":
                    packageName = ap.h;
                    return packageName;
                case "sdkversion":
                    boolean z = ap.b;
                    packageName = "6.3.3CR001B1208";
                    return packageName;
                case "testversion":
                    boolean z2 = ap.b;
                    packageName = "6.3.3CR001B1208_20251208v1";
                    return packageName;
                case "debuginfo":
                    packageName = au.b(0);
                    return packageName;
                case "debuginfoall":
                    packageName = au.b(1);
                    return packageName;
                case "debuginforesult":
                    packageName = au.b(2);
                    return packageName;
                case "deviceinfo":
                    packageName = v.b();
                    return packageName;
                case "debuginfocosttime":
                    packageName = au.b(3);
                    return packageName;
                default:
                    throw new Exception("no info");
            }
        } catch (Exception e) {
            return "no info:" + e.toString();
        }
    }

    /* JADX WARN: Code duplicated, block: B:25:0x0057  */
    public boolean cuDebugInfoBoolean(String str) throws Exception {
        byte b;
        bp.e().getClass();
        if (bp.b() == null) {
            throw new Exception("sdk 未初始化, context 为空");
        }
        try {
            String lowerCase = str.toLowerCase();
            int iHashCode = lowerCase.hashCode();
            if (iHashCode != 125151933) {
                if (iHashCode != 447977265) {
                    if (iHashCode != 1186807453) {
                        if (iHashCode == 1728343896 && lowerCase.equals("getcacheflag")) {
                            b = 0;
                        } else {
                            b = -1;
                        }
                    } else if (lowerCase.equals("getcbinmainthread")) {
                        b = 1;
                    } else {
                        b = -1;
                    }
                } else if (lowerCase.equals("getlogenable")) {
                    b = 2;
                } else {
                    b = -1;
                }
            } else if (lowerCase.equals("getcryptogm")) {
                b = 3;
            } else {
                b = -1;
            }
            if (b == 0) {
                return ap.e;
            }
            if (b == 1) {
                return ap.f;
            }
            if (b == 2) {
                return as.b;
            }
            if (b == 3) {
                return ap.g;
            }
            throw new Exception("no info");
        } catch (Exception unused) {
            throw new Exception("no info");
        }
    }

    public void cuGetToken(int i, ResultListener resultListener) {
        int i2 = ap.g ? 3 : 2;
        if ((l.b & 7) != 0) {
            l.b(i2, resultListener, 410023, "取号服务中，勿重复调用", i);
        } else {
            cuPreGetToken(i, i2, StrcuPreGetToken, resultListener);
        }
    }

    public void cuGetTokenLoop(int i, int i2, ResultListener resultListener) {
        cuGetTokenLoop(i, ap.g ? 3 : 2, i2, resultListener);
    }

    public void cuMobileAuth(int i, ResultListener resultListener) {
        int i2 = ap.g ? 5 : 4;
        if ((l.b & 7) != 0) {
            l.b(i2, resultListener, 410023, "取号服务中，勿重复调用", i);
        } else {
            cuPreGetToken(i, i2, StrcuPreGetToken, resultListener);
        }
    }

    public String getProtocolUrl(int i) {
        return i != 0 ? new String(aq.b("aHR0cHM6Ly9tc3Y2Lndvc21zLmNuL2h0bWwvb2F1dGgvcHJvdG9jb2wyLmh0bWw=")) : "aHR0cHM6Ly9tc3Y2Lndvc21zLmNuL2h0bWwvb2F1dGgvcHJvdG9jb2wyLmh0bWw=";
    }

    public String getSdkVersion() {
        bp.e().getClass();
        boolean z = ap.b;
        return "6.3.3CR001B1208";
    }

    public UniAccountHelper init(Context context, String str) {
        return init(context, str, false);
    }

    public void releaseNetwork() {
        bp.e().getClass();
    }

    public UniAccountHelper setCBinMainThread(boolean z) {
        ap.f = z;
        return s_instance;
    }

    public UniAccountHelper setCertFingerType(String str) {
        if (!str.equalsIgnoreCase(bz.f456a) && !str.equalsIgnoreCase("SHA1") && !str.equalsIgnoreCase("SHA256") && !str.equalsIgnoreCase("sm3")) {
            return null;
        }
        ap.h = str.toLowerCase();
        return s_instance;
    }

    public UniAccountHelper setCryptoGM(boolean z) {
        ap.g = z;
        return s_instance;
    }

    public void setLogEnable(boolean z) {
        ar.b = z;
        bp.e().getClass();
        as.b = z;
        bp.e().getClass();
    }

    public UniAccountHelper setUseCacheFlag(boolean z) {
        ap.e = z;
        return s_instance;
    }

    private void initFail(int i, ResultListener resultListener, int i2, String str, int i3) {
        ar.b("type:" + i + "\nmsg:" + str);
        try {
            String strC = bp.c();
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("resultCode", i2);
            jSONObject.put("resultMsg", str);
            jSONObject.put("resultData", "");
            jSONObject.put("seq", strC);
            l.b();
            if (resultListener != null) {
                resultListener.onResult(jSONObject.toString());
            }
            bp.e().getClass();
            if (ap.b) {
                bp.e().getClass();
                String strB = bp.b(1, 1, strC, i2, i3, i2, str);
                bp.e().getClass();
                an.b(bp.b(), strB);
            }
        } catch (Exception e) {
            if (ar.b) {
                e.printStackTrace();
            }
        }
    }

    /* JADX WARN: Code duplicated, block: B:43:0x0112 A[Catch: Exception -> 0x0125, TryCatch #0 {Exception -> 0x0125, blocks: (B:15:0x007b, B:17:0x0081, B:20:0x0089, B:22:0x0091, B:23:0x009d, B:25:0x00ac, B:26:0x00b7, B:31:0x00c8, B:33:0x00ee, B:35:0x00f6, B:37:0x00fe, B:39:0x0106, B:42:0x010f, B:44:0x0114, B:43:0x0112, B:30:0x00c5, B:49:0x0127, B:27:0x00ba), top: B:56:0x007b, inners: #1 }] */
    /* JADX WARN: Code duplicated, block: B:49:0x0127 A[Catch: Exception -> 0x0125, TRY_ENTER, TRY_LEAVE, TryCatch #0 {Exception -> 0x0125, blocks: (B:15:0x007b, B:17:0x0081, B:20:0x0089, B:22:0x0091, B:23:0x009d, B:25:0x00ac, B:26:0x00b7, B:31:0x00c8, B:33:0x00ee, B:35:0x00f6, B:37:0x00fe, B:39:0x0106, B:42:0x010f, B:44:0x0114, B:43:0x0112, B:30:0x00c5, B:49:0x0127, B:27:0x00ba), top: B:56:0x007b, inners: #1 }] */
    public UniAccountHelper init(Context context, String str, boolean z) {
        String str2 = str + str;
        if (context == null || TextUtils.isEmpty(str) || TextUtils.isEmpty(str2)) {
            ar.b("初始化参数不能为空");
            return null;
        }
        if (l.c() != null) {
            ar.b("重复初始化");
            return null;
        }
        l.b();
        initialize(context);
        bp bpVarE = bp.e();
        Context contextC = l.c();
        bpVarE.getClass();
        as.d = 0;
        as.e = 0;
        StringBuilder sb = as.g;
        sb.setLength(0);
        sb.append("\n\n■★■★■★■★■★■★■★■★■★■\n\ncom debug info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        StringBuilder sb2 = as.f;
        sb2.setLength(0);
        sb2.append("\n\n■★■★■★■★■★■★■★■★■★■\n\nall debug info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        StringBuilder sb3 = as.h;
        sb3.setLength(0);
        sb3.append("\n\n■★■★■★■★■★■★■★■★■★■\n\nresult  info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        StringBuilder sb4 = as.i;
        sb4.setLength(0);
        sb4.append("\n\n■★■★■★■★■★■★■★■★■★■\n\ncost time  info\n\n■★■★■★■★■★■★■★■★■★■\n\n");
        as.b(StrcuPreGetToken, 0);
        au.c = 0;
        au.b = 0;
        if (contextC != null) {
            try {
                if (TextUtils.isEmpty(str) || TextUtils.isEmpty(str2)) {
                    boolean z2 = ap.b;
                    Log.e("UniAccount", "6.3.3CR001B1208 初始化参数不能为空");
                    as.b("初始化参数不能为空", 0);
                } else {
                    if (TextUtils.isEmpty(ap.j)) {
                        ap.g = z;
                        ap.e = true;
                        ap.h = TKDownloadReason.KSAD_TK_MD5;
                        boolean z3 = ap.b;
                        if (bp.d == null) {
                            bp.d = new WeakReference(contextC.getApplicationContext());
                        }
                        bp.b();
                        try {
                            ap.j = str;
                            au.b(bp.b());
                        } catch (Exception e) {
                            as.b(e);
                        }
                        au.b(bp.b());
                        boolean z4 = ap.b;
                        v.b(bp.b());
                        ao.b();
                        String str3 = new String(aq.b("bXN2Ni53b3Ntcy5jbg=="));
                        if (str3.equalsIgnoreCase(ao.c) || str3.equalsIgnoreCase(ao.d)) {
                            ap.i = str3;
                        } else {
                            String str4 = ao.b;
                            if (str3.equalsIgnoreCase(str4) || str3.equalsIgnoreCase(ao.e) || str3.endsWith(ao.i)) {
                                ap.i = str3;
                            } else {
                                ap.i = str4;
                            }
                        }
                        ap.b = false;
                        ap.d = true;
                        ap.c = true;
                        bpVarE.f();
                        v.b();
                        String str5 = Build.BRAND;
                        return s_instance;
                    }
                    Log.e("UniAccount", "6.3.3CR001B1208 不可重复初始化 init");
                    as.b("不可重复初始化 init", 0);
                }
            } catch (Exception e2) {
                as.b(e2);
            }
        } else {
            boolean z5 = ap.b;
            Log.e("UniAccount", "6.3.3CR001B1208 初始化参数不能为空");
            as.b("初始化参数不能为空", 0);
        }
        ar.b("UniAuthHelper.getInstance().init 初始化错误");
        return null;
    }

    /* JADX WARN: Code duplicated, block: B:11:0x0042 A[PHI: r1
  0x0042: PHI (r1v6 int) = (r1v4 int), (r1v5 int) binds: [B:10:0x0040, B:13:0x0045] A[DONT_GENERATE, DONT_INLINE]] */
    private void cuGetTokenLoop(int i, int i2, int i3, ResultListener resultListener) {
        String str = "cuGetTokenLoop ---> " + System.currentTimeMillis();
        if (ar.b) {
            Log.d("UniAccount", "6.3.3 " + str);
        }
        int i4 = l.b;
        if ((i4 & 7) != 0) {
            l.b(i2, resultListener, 410023, "取号服务中，勿重复调用", i3);
            return;
        }
        int i5 = 1;
        l.b = i4 | 1;
        int i6 = l.c;
        if (i <= 0) {
            i = i5;
        } else {
            i5 = 5;
            if (i > 5) {
                i = i5;
            }
        }
        int i7 = i6 + i;
        l.c = i7;
        l.d = i7;
        cuGetTokenUaidLoopCommon(0, i2, i3, resultListener);
    }
}
