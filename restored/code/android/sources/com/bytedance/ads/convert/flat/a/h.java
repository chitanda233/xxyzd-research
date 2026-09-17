package com.bytedance.ads.convert.flat.a;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkCapabilities;
import android.net.NetworkInfo;
import java.util.Map;
import kotlin.Lazy;
import kotlin.LazyKt;
import kotlin.TuplesKt;
import kotlin.collections.MapsKt;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes2.dex */
public final class h {
    public static final h c = new h();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final f f1682a = new f(false, null, null, null, 15);
    public static final Lazy b = LazyKt.lazy(a.f1683a);

    public static final class a extends Lambda implements Function0<Map<String, ? extends com.bytedance.ads.convert.flat.a.a>> {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final a f1683a = new a();

        public a() {
            super(0);
        }

        @Override // kotlin.jvm.functions.Function0
        public Map<String, ? extends com.bytedance.ads.convert.flat.a.a> invoke() {
            h hVar = h.c;
            f fVar = h.f1682a;
            return MapsKt.mapOf(TuplesKt.to("1", new b(fVar.b)), TuplesKt.to("2", new c(fVar.c)), TuplesKt.to("3", new d(fVar.d)));
        }
    }

    public static final String a(h hVar, Context context) {
        Network activeNetwork;
        NetworkCapabilities networkCapabilities;
        if (context.checkSelfPermission(com.kuaishou.weapon.p0.g.b) != -1) {
            com.bytedance.ads.convert.flat.c.c netWorkUtils = com.bytedance.ads.convert.flat.c.c.a(context);
            Intrinsics.checkNotNullExpressionValue(netWorkUtils, "netWorkUtils");
            netWorkUtils.getClass();
            int i = 0;
            try {
                ConnectivityManager connectivityManager = netWorkUtils.b;
                NetworkInfo activeNetworkInfo = connectivityManager != null ? connectivityManager.getActiveNetworkInfo() : null;
                if (activeNetworkInfo != null && activeNetworkInfo.isAvailable() && (activeNetwork = netWorkUtils.b.getActiveNetwork()) != null && (networkCapabilities = netWorkUtils.b.getNetworkCapabilities(activeNetwork)) != null) {
                    boolean zHasTransport = networkCapabilities.hasTransport(4);
                    boolean zHasTransport2 = networkCapabilities.hasTransport(0);
                    boolean zHasTransport3 = networkCapabilities.hasTransport(1);
                    if (zHasTransport) {
                        i = 4;
                    } else if (com.bytedance.ads.convert.flat.c.c.a(netWorkUtils.b) && zHasTransport3) {
                        i = 3;
                    } else if (zHasTransport3) {
                        i = 1;
                    } else {
                        i = zHasTransport2 ? 2 : 5;
                    }
                }
            } catch (Exception unused) {
            }
            if (i != 3 || context.checkSelfPermission("android.permission.CHANGE_NETWORK_STATE") != -1) {
                return (i == 3 || i == 2) ? "41128" : "21128" + i;
            }
        }
        return "31128";
    }

    public final i a() {
        for (Map.Entry entry : ((Map) b.getValue()).entrySet()) {
            if (Intrinsics.areEqual(((com.bytedance.ads.convert.flat.a.a) entry.getValue()).b.b, "01128")) {
                return ((com.bytedance.ads.convert.flat.a.a) entry.getValue()).b;
            }
        }
        return new i("111128");
    }

    public final void a(f newConfig) {
        Intrinsics.checkNotNullParameter(newConfig, "config");
        f fVar = f1682a;
        fVar.getClass();
        Intrinsics.checkNotNullParameter(newConfig, "newConfig");
        fVar.f1679a = newConfig.f1679a;
        e eVar = fVar.b;
        e eVar2 = newConfig.b;
        eVar.f1678a = eVar2.f1678a;
        eVar.b = eVar2.b;
        e eVar3 = fVar.c;
        e eVar4 = newConfig.c;
        eVar3.f1678a = eVar4.f1678a;
        eVar3.b = eVar4.b;
        e eVar5 = fVar.d;
        e eVar6 = newConfig.d;
        eVar5.f1678a = eVar6.f1678a;
        eVar5.b = eVar6.b;
    }
}
