package com.unicom.online.account.kernel;

import android.content.Context;
import android.text.TextUtils;
import java.security.KeyFactory;
import java.security.PublicKey;
import java.security.spec.X509EncodedKeySpec;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.atomic.AtomicBoolean;
import javax.crypto.Cipher;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class i {
    public av e;
    public final AtomicBoolean d = new AtomicBoolean(false);
    public final ab f = new ab();
    public final ExecutorService c = Executors.newSingleThreadExecutor();
    public ScheduledExecutorService b = Executors.newScheduledThreadPool(1);

    public final void b(String str) {
        if (this.d.get()) {
            return;
        }
        this.d.set(true);
        try {
            this.f.b();
        } catch (Exception e) {
            as.b(e);
        }
        try {
            ExecutorService executorService = this.c;
            if (executorService != null && !executorService.isShutdown()) {
                this.c.shutdownNow();
            }
        } catch (Exception e2) {
            as.b(e2);
        }
        try {
            ScheduledExecutorService scheduledExecutorService = this.b;
            if (scheduledExecutorService != null) {
                scheduledExecutorService.shutdownNow();
                this.b = null;
            }
        } catch (Exception e3) {
            as.b(e3);
        }
    }

    public final void c(Context context, int i) {
        f fVar = new f(this);
        try {
            int iC = au.c(context.getApplicationContext());
            String str = ao.b;
            if (iC == 1) {
                as.b("requestPreCheck： WIFI + FLOW");
                b(context, i, fVar);
            } else if (iC == 0) {
                as.b("requestPreCheck： FLOW");
                u.b().getClass();
                b(context, i, null, fVar);
            } else {
                as.b("requestPreCheck： NO_CELL");
                fVar.b(i, 410004, "数据网络未开启");
            }
        } catch (Exception e) {
            as.b(e);
            fVar.b(i, 410005, "网络判断异常" + e.getMessage());
        }
    }

    public static String b(Context context, int i) {
        String strC;
        String strB;
        String str;
        String strB2;
        String str2;
        String strC2;
        try {
            String str3 = ap.j;
            String str4 = "" + System.currentTimeMillis();
            String packageName = context.getPackageName();
            String strB3 = j.b(context, au.b());
            String strC3 = ao.c();
            String strSubstring = strC3.substring(0, 16);
            String strSubstring2 = strC3.substring(16, 32);
            u.b().c = System.currentTimeMillis();
            if (ap.g) {
                str = "3.1";
                byte[] bytes = strB3.getBytes("Utf-8");
                byte[] bytes2 = strSubstring.getBytes();
                byte[] bytes3 = strSubstring2.getBytes();
                ad.c.getClass();
                strC = aq.b(bc.b(bytes2, bytes3, bytes, 1));
                strB = aq.b(ad.b(strC3.getBytes(), k.b()));
            } else {
                try {
                    strC = b.c(strB3, strSubstring, strSubstring2);
                } catch (Exception e) {
                    as.b(e);
                    strC = null;
                }
                PublicKey publicKeyGeneratePublic = KeyFactory.getInstance(com.alipay.sdk.m.p.d.f334a).generatePublic(new X509EncodedKeySpec(aq.b("MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCVc1ecjpc5k7TkabF935iQONDZ0/E5XWPVv9FEsI59XTRW0+BCMK1MODRSWMvHFrPMh9ZilnRr7qXuAKCBEynQEghmpIVvMYhFu48FAI9bKfkI5lKuQK+tc4X0+zTbNrpedNoKXK4C7dDjTETBH6prwWE9j5WsAf0gbjUbIs3FxwIDAQAB")));
                Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
                cipher.init(1, publicKeyGeneratePublic);
                strB = aq.b(cipher.doFinal(strC3.getBytes()));
                str = "2.1";
            }
            if (ap.h.equalsIgnoreCase("sm3")) {
                strB2 = au.b(context, context.getPackageName());
            } else {
                strB2 = au.b(context, context.getPackageName(), ap.h);
            }
            if (ap.b(i)) {
                str2 = ao.r;
                if (!TextUtils.isEmpty(str2)) {
                    str2 = "0";
                }
            } else {
                str2 = "";
            }
            String strReplaceAll = (strB2 + "\n" + str3 + "\n" + str + "\njson\n" + str2 + "\n" + packageName + "\n" + strC + "\n6.3.3CR001B1208\n" + strB + "\n" + str4).replaceAll("\n", "");
            if (ap.g) {
                strC2 = bb.b(strReplaceAll);
            } else {
                strC2 = au.c(strReplaceAll);
            }
            String strReplaceAll2 = strC.replaceAll("\\+", "%2B");
            String strReplaceAll3 = strB.replaceAll("\\+", "%2B");
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("androidMd5", strB2);
            jSONObject.put("apiKey", str3);
            jSONObject.put(com.alipay.sdk.m.n.c.m, str);
            jSONObject.put("format", "json");
            if (ap.b(i)) {
                jSONObject.put("operator", str2);
            }
            jSONObject.put("packName", packageName);
            jSONObject.put("privateIp", strReplaceAll2);
            jSONObject.put("sdkVersion", "6.3.3CR001B1208");
            jSONObject.put("secretKey", strReplaceAll3);
            jSONObject.put("timeStamp", str4);
            jSONObject.put("sign", strC2);
            return jSONObject.toString();
        } catch (Exception e2) {
            as.b(e2);
            return "";
        }
    }

    public final void b(final Context context, final int i, final f fVar) {
        final long jCurrentTimeMillis = System.currentTimeMillis();
        Thread.currentThread().getName();
        final CountDownLatch countDownLatch = new CountDownLatch(1);
        Executors.newCachedThreadPool().execute(new Runnable() { // from class: com.unicom.online.account.kernel.i$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b(context, countDownLatch, jCurrentTimeMillis, i, fVar);
            }
        });
    }

    public final /* synthetic */ void b(Context context, CountDownLatch countDownLatch, long j, int i, f fVar) {
        try {
            this.f.b(context, new g(this, countDownLatch, j, context, i, fVar));
        } catch (Exception unused) {
            countDownLatch.countDown();
        }
    }

    public final void b(Context context, int i, Object obj, f fVar) {
        synchronized (this) {
            try {
                this.c.submit(new h(this, context, obj, i, fVar));
            } catch (Exception e) {
                fVar.b(i, 410009, "410009" + e.getMessage());
            }
        }
    }
}
