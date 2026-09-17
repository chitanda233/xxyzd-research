package com.bytedance.ads.convert.flat.a;

import android.content.Context;
import android.content.SharedPreferences;
import android.net.ConnectivityManager;
import android.net.Network;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import java.util.Map;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes2.dex */
public final class g implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Context f1680a;
    public final /* synthetic */ com.bytedance.ads.convert.flat.b.a b;

    public static final class a implements com.bytedance.ads.convert.flat.c.c.b {
        public final /* synthetic */ com.bytedance.ads.convert.flat.a.a b;

        public a(com.bytedance.ads.convert.flat.a.a aVar) {
            this.b = aVar;
        }

        @Override // com.bytedance.ads.convert.flat.c.c.b
        public final void a(Network network) {
            i iVarB;
            com.bytedance.ads.convert.flat.a.a aVar = this.b;
            Context context = g.this.f1680a;
            synchronized (aVar) {
                Intrinsics.checkNotNullParameter(context, "context");
                if (aVar.d.f1678a) {
                    if (Intrinsics.areEqual(aVar.b.b, "-11128")) {
                        SharedPreferences sharedPreferences = context.getSharedPreferences("sp_name_bd_convert_uid_0", 0);
                        Intrinsics.checkNotNullExpressionValue(sharedPreferences, "context.getSharedPrefere…t\", Context.MODE_PRIVATE)");
                        long j = sharedPreferences.getLong(aVar.a() + "uid_time", 0L);
                        if (j != 0 && System.currentTimeMillis() - j < aVar.f1675a) {
                            String string = sharedPreferences.getString(aVar.a() + "uid_carrier", aVar.b.c);
                            String string2 = sharedPreferences.getString(aVar.a() + "uid_vendor", aVar.b.d);
                            String string3 = sharedPreferences.getString(aVar.a() + "uid_errCode", aVar.b.b);
                            String string4 = sharedPreferences.getString(aVar.a() + "uid_token", aVar.b.f1684a);
                            String string5 = sharedPreferences.getString(aVar.a() + "uid_province", aVar.b.f);
                            i iVar = aVar.b;
                            iVar.f1684a = string4;
                            iVar.b = string3;
                            iVar.d = string2;
                            iVar.c = string;
                            iVar.e = 0;
                            iVar.f = string5;
                            iVar.g = System.currentTimeMillis();
                        }
                    }
                    iVarB = (System.currentTimeMillis() - aVar.b.g <= aVar.f1675a && !TextUtils.isEmpty(aVar.b.f1684a)) ? aVar.b : aVar.b(context, network);
                } else {
                    iVarB = new i("101128");
                }
            }
            com.bytedance.ads.convert.flat.c.c cVarA = com.bytedance.ads.convert.flat.c.c.a(g.this.f1680a);
            synchronized (cVarA) {
                ConnectivityManager connectivityManager = cVarA.b;
                if (connectivityManager != null) {
                    try {
                        ConnectivityManager.NetworkCallback networkCallback = cVarA.d;
                        if (networkCallback != null) {
                            connectivityManager.unregisterNetworkCallback(networkCallback);
                            cVarA.d = null;
                            cVarA.c = null;
                        }
                    } catch (Exception unused) {
                    }
                }
            }
            com.bytedance.ads.convert.flat.b.a aVar2 = g.this.b;
            if (aVar2 != null) {
                aVar2.a(iVarB);
            }
        }
    }

    public g(Context context, com.bytedance.ads.convert.flat.b.a aVar) {
        this.f1680a = context;
        this.b = aVar;
    }

    @Override // java.lang.Runnable
    public final void run() {
        com.bytedance.ads.convert.flat.b.a aVar;
        i iVar;
        String str;
        try {
            String strA = h.a(h.c, this.f1680a);
            if (Intrinsics.areEqual(strA, "41128")) {
                TelephonyManager telephonyManager = (TelephonyManager) this.f1680a.getSystemService("phone");
                String simOperator = telephonyManager.getSimOperator();
                if (telephonyManager.getSimState() != 5) {
                    simOperator = "";
                }
                simOperator.hashCode();
                simOperator.hashCode();
                switch (simOperator) {
                    case "46000":
                    case "46002":
                    case "46004":
                    case "46007":
                    case "46008":
                        str = "1";
                        break;
                    case "46001":
                    case "46006":
                    case "46009":
                        str = "3";
                        break;
                    case "46003":
                    case "46005":
                    case "46011":
                        str = "2";
                        break;
                    default:
                        str = "0";
                        break;
                }
                com.bytedance.ads.convert.flat.a.a aVar2 = (com.bytedance.ads.convert.flat.a.a) ((Map) h.b.getValue()).get(str);
                if (aVar2 != null) {
                    if (Intrinsics.areEqual(aVar2.b.b, "-11128")) {
                        com.bytedance.ads.convert.flat.c.c.a(this.f1680a).a(new a(aVar2));
                        return;
                    }
                    com.bytedance.ads.convert.flat.b.a aVar3 = this.b;
                    if (aVar3 != null) {
                        aVar3.a(aVar2.b);
                        return;
                    }
                    return;
                }
                aVar = this.b;
                if (aVar == null) {
                    return;
                } else {
                    iVar = new i("11128");
                }
            } else {
                com.bytedance.ads.convert.flat.b.a aVar4 = this.b;
                if (aVar4 == null) {
                    return;
                }
                i iVar2 = new i(strA);
                aVar = aVar4;
                iVar = iVar2;
            }
            aVar.a(iVar);
        } catch (Exception e) {
            com.bytedance.ads.convert.flat.b.a aVar5 = this.b;
            if (aVar5 != null) {
                String message = e.getMessage();
                if (message == null) {
                    message = "unknow";
                }
                aVar5.a(new i(message));
            }
        }
    }
}
