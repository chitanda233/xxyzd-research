package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.Network;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class az {
    public final Context c;
    public final ab e;
    public final s f;
    public final AtomicBoolean g;
    public final int h;
    public int b = 0;
    public String d = j.b;

    public az(Context context, ab abVar, s sVar, AtomicBoolean atomicBoolean, int i) {
        this.c = context;
        this.e = abVar;
        this.f = sVar;
        this.g = atomicBoolean;
        this.h = i;
    }

    public static void b(s sVar, Object obj) {
        try {
            if (sVar.f) {
                throw new IllegalStateException("ConnectionPoolManager已释放，不能再次使用");
            }
            q qVar = sVar.b;
            if (qVar != null) {
                qVar.b();
            }
            q qVar2 = sVar.b;
            if (qVar2 != null) {
                qVar2.c();
            }
            sVar.b = new q();
            try {
                Network network = (Network) obj;
                if (sVar.f) {
                    throw new IllegalStateException("ConnectionPoolManager已释放，不能再次使用");
                }
                sVar.d = network;
                sVar.c();
            } catch (Exception e) {
                e.getMessage();
            }
        } catch (Exception e2) {
            e2.getMessage();
        }
    }

    public final boolean b() {
        int i = this.b;
        int i2 = i + 1;
        this.b = i2;
        if (i2 <= 2) {
            try {
                Thread.sleep(Math.min(((long) Math.pow(2.0d, i)) * 100, 400L));
                return true;
            } catch (InterruptedException unused) {
                Thread.currentThread().interrupt();
            }
        }
        return false;
    }

    public final ax b(Object obj) {
        if (obj != null) {
            try {
                this.e.b();
            } catch (Exception e) {
                e.getMessage();
            }
        }
        int iC = au.c(this.c.getApplicationContext());
        String str = ao.b;
        Object[] objArr = {null};
        if (iC == 1) {
            CountDownLatch countDownLatch = new CountDownLatch(1);
            try {
                this.e.b(this.c, new aw(objArr, countDownLatch));
                countDownLatch.await(2500L, TimeUnit.MILLISECONDS);
                Object obj2 = objArr[0];
                if (obj2 != null) {
                    return new ax(obj2, true);
                }
            } catch (Exception e2) {
                e2.printStackTrace();
                e2.getMessage();
            }
        } else if (iC == 0) {
            objArr[0] = null;
            return new ax(null, true);
        }
        return new ax(null, false);
    }

    /* JADX WARN: Code duplicated, block: B:20:0x0052  */
    public static ay b(String str) {
        String strTrim;
        int iIndexOf;
        if (str == null) {
            return null;
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            if (jSONObject.has("data")) {
                String strOptString = jSONObject.optString("data", "");
                if (strOptString.contains("requestUrl:") || strOptString.contains("requestUrl->")) {
                    if (strOptString.indexOf("requestUrl:") != -1) {
                        iIndexOf = strOptString.indexOf("requestUrl:") + 11;
                    } else {
                        iIndexOf = strOptString.indexOf("requestUrl->") + 12;
                    }
                    int iIndexOf2 = strOptString.indexOf("\n", iIndexOf);
                    if (iIndexOf2 == -1) {
                        iIndexOf2 = strOptString.length();
                    }
                    strTrim = strOptString.substring(iIndexOf, iIndexOf2).trim();
                } else {
                    strTrim = null;
                }
            } else {
                strTrim = null;
            }
            int iOptInt = jSONObject.has("callDepth") ? jSONObject.optInt("callDepth", 0) : 0;
            if (strTrim != null) {
                return new ay(strTrim, iOptInt);
            }
        } catch (Exception e) {
            e.getMessage();
        }
        return null;
    }

    public final String b(String str, int i) {
        String str2;
        String strB = j.b(this.c, au.b());
        String str3 = this.d;
        if (str3 == null || !str3.equals(strB)) {
            try {
                str2 = ao.b(i) + aj.b(i.b(this.c, i));
            } catch (Exception e) {
                e.getMessage();
                str2 = null;
            }
            if (str2 != null && !str2.isEmpty()) {
                "RetryController: 由于私网IP变化，URL已重新生成: ".concat(str2);
                str = str2;
            }
            this.d = strB;
        }
        return str;
    }
}
