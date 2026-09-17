package com.qq.gdt.action.d;

import android.content.Context;
import android.os.Handler;
import android.os.HandlerThread;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.qq.gdt.action.GDTAction;
import com.qq.gdt.action.i.o;
import com.tencent.turingfd.sdk.ams.ad.ITuringDID;
import com.tencent.turingfd.sdk.ams.ad.ITuringDeviceInfoProvider;
import com.tencent.turingfd.sdk.ams.ad.ITuringPrivacyPolicy;
import com.tencent.turingfd.sdk.ams.ad.TuringIDService;
import com.tencent.turingfd.sdk.ams.ad.TuringSDK;
import java.lang.ref.WeakReference;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Handler f3035a;
    private static Handler b;
    private static final AtomicBoolean c = new AtomicBoolean(false);

    public static final class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f3038a;
        public String b;
        public String c;
        public String d;
        public String e;
        public String f;
        public String g;
        public String h;
        public String i;
        public String j;
        public String k;
    }

    public static final class b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f3039a;
        public String b;
        public String c;
        public int d;
    }

    public static a a(Context context, boolean z) {
        a aVar = new a();
        if (context == null) {
            return aVar;
        }
        com.qq.gdt.action.d.a();
        boolean zU = com.qq.gdt.action.d.u();
        aVar.f3038a = c.a(com.qq.gdt.action.d.b.a(context, zU));
        aVar.b = c.a(com.qq.gdt.action.d.b.a(context, 0, zU));
        aVar.c = c.a(com.qq.gdt.action.d.b.a(context, 1, zU));
        aVar.d = c.a(com.qq.gdt.action.d.b.b(context, zU));
        aVar.e = c.a(com.qq.gdt.action.d.b.b(context, 0, zU));
        aVar.f = c.a(com.qq.gdt.action.d.b.b(context, 1, zU));
        aVar.g = c.a(com.qq.gdt.action.d.b.c(context, zU));
        aVar.h = c.a(com.qq.gdt.action.d.b.c(context, 0, zU));
        aVar.i = c.a(com.qq.gdt.action.d.b.c(context, 1, zU));
        aVar.j = com.qq.gdt.action.d.a.a(com.qq.gdt.action.d.b.a(context));
        aVar.k = h.a(context, z, zU);
        return aVar;
    }

    public static void a(Context context) {
        new HandlerThread("appwaid").start();
        c(context);
        HandlerThread handlerThread = new HandlerThread("oaid");
        handlerThread.start();
        f3035a = new Handler(handlerThread.getLooper());
        a(context, 0L);
        HandlerThread handlerThread2 = new HandlerThread("openDeviceIdentifier");
        handlerThread2.start();
        b = new Handler(handlerThread2.getLooper());
        d(context);
    }

    private static void a(final Context context, long j) {
        if (context == null) {
            return;
        }
        final WeakReference weakReference = new WeakReference(context.getApplicationContext());
        f3035a.postDelayed(new Runnable() { // from class: com.qq.gdt.action.d.d.3
            @Override // java.lang.Runnable
            public void run() {
                o.a(String.format("updateForAidTicketAndTaidTicket", new Object[0]), new Object[0]);
                ITuringDID turingDID = TuringIDService.getTuringDID((Context) weakReference.get());
                if (turingDID == null) {
                    o.a("updateForAidTicketAndTaidTicket TuringDIDService.getTuringDID return null", new Object[0]);
                    return;
                }
                o.a(String.format("updateForAidTicketAndTaidTicket errorCode:%d, aidTicket:%s, taid:%s, expiredTimestamp:%d", Integer.valueOf(turingDID.getErrorCode()), turingDID.getAIDTicket(), "", Long.valueOf(turingDID.getExpiredTimestamp())), new Object[0]);
                if (turingDID.getErrorCode() == 0) {
                    if (com.qq.gdt.action.b.a(context).f() > 0) {
                        d.f3035a.postDelayed(this, com.qq.gdt.action.b.a(context).f());
                    }
                    if (GDTAction.getAutoStartEnable() && d.c.compareAndSet(false, true)) {
                        GDTAction.logAction("TENCENT_INNER_START_APP");
                    }
                } else if (turingDID.getErrorCode() == -10004 || turingDID.getErrorCode() == -10012 || turingDID.getErrorCode() == -21052 || turingDID.getErrorCode() == -22056 || turingDID.getErrorCode() == -10009) {
                    d.f3035a.postDelayed(this, com.qq.gdt.action.b.a(context).u());
                }
                if (turingDID.getErrorCode() != 0) {
                    JSONObject jSONObjectD = d.d();
                    try {
                        jSONObjectD.put(MediationConstant.KEY_ERROR_CODE, turingDID.getErrorCode());
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                    com.qq.gdt.action.g.a.a(3504, jSONObjectD);
                }
            }
        }, j);
    }

    public static b b(Context context) {
        b bVar = new b();
        if (context == null) {
            return bVar;
        }
        ITuringDID turingDIDCached = TuringIDService.getTuringDIDCached(context.getApplicationContext());
        if (turingDIDCached == null) {
            o.a("fillAidTicketAndTaid TuringDIDService.getTuringDIDCached return null", new Object[0]);
            return bVar;
        }
        o.a(String.format("fillAidTicketAndTaid errorCode:%d aidTicket:%s, taidTicket:%s, expiredTimestamp:%d", Integer.valueOf(turingDIDCached.getErrorCode()), turingDIDCached.getAIDTicket(), "", Long.valueOf(turingDIDCached.getExpiredTimestamp())), new Object[0]);
        bVar.f3039a = turingDIDCached.getAIDTicket();
        bVar.b = "";
        bVar.c = turingDIDCached.getTAIDTicket();
        bVar.d = turingDIDCached.getErrorCode();
        if (turingDIDCached.getErrorCode() != 0) {
            JSONObject jSONObjectD = d();
            try {
                jSONObjectD.put(MediationConstant.KEY_ERROR_CODE, turingDIDCached.getErrorCode());
            } catch (JSONException e) {
                e.printStackTrace();
            }
            com.qq.gdt.action.g.a.a(3503, jSONObjectD);
        }
        return bVar;
    }

    private static void c(final Context context) {
        try {
            o.a(String.format("initTAIDSDK versionInfo:%s", TuringSDK.getVersionInfo()), new Object[0]);
            if (context == null) {
                o.c("init aid context is null");
            }
            int iInit = TuringSDK.createConf(context, new ITuringPrivacyPolicy() { // from class: com.qq.gdt.action.d.d.2
                @Override // com.tencent.turingfd.sdk.ams.ad.ITuringPrivacyPolicy, com.tencent.turingfd.sdk.ams.ad.Lynx
                public boolean userAgreement() {
                    return com.qq.gdt.action.d.a().x();
                }
            }).turingDeviceInfoProvider(new ITuringDeviceInfoProvider() { // from class: com.qq.gdt.action.d.d.1
                @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDeviceInfoProvider
                public String getAndroidId() {
                    return com.qq.gdt.action.d.b.a(context);
                }

                @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDeviceInfoProvider
                public String getImei() {
                    return "";
                }

                @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDeviceInfoProvider
                public String getImsi() {
                    return g.a();
                }
            }).channel(105548).autoRequestBg(true).build().init();
            if (iInit != 0) {
                JSONObject jSONObjectD = d();
                jSONObjectD.put(MediationConstant.KEY_ERROR_CODE, iInit);
                com.qq.gdt.action.g.a.a(3505, jSONObjectD);
            }
        } catch (Throwable unused) {
            o.c("GDTAction初始化失败，ErrorCode:02，请联系广点通运营");
            com.qq.gdt.action.g.a.a(3502, d());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static JSONObject d() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("actionSetId", com.qq.gdt.action.d.a().h());
            jSONObject.put("deviceId", com.qq.gdt.action.d.a().o());
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }

    private static void d(Context context) {
        if (context == null) {
            o.a("create error", new Object[0]);
        } else {
            a(context, true);
            b(context);
        }
    }
}
