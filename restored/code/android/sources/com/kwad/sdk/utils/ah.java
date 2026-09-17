package com.kwad.sdk.utils;

import android.content.Context;
import android.content.SharedPreferences;
import android.text.TextUtils;
import android.util.Log;
import com.kwad.sdk.service.ServiceProvider;
import java.util.Iterator;
import java.util.Map;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public final class ah {
    private static AtomicInteger bpp = new AtomicInteger(0);
    private static volatile boolean bpq = false;
    private static volatile boolean bpr;

    private static boolean Vh() {
        return true;
    }

    private static int Vb() {
        com.kwad.sdk.service.a.h hVar = (com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class);
        if (hVar == null) {
            com.kwad.sdk.core.d.c.w("Ks_UnionHelper", "sdkConfigProvider == null");
            return 0;
        }
        int iGf = hVar.Gf();
        com.kwad.sdk.core.d.c.d("Ks_UnionHelper", "config mode:" + iGf);
        return iGf;
    }

    private static void Vc() {
        if (bpq) {
            return;
        }
        bpp.set(Vf());
        bpr = bq.m("kssdk_kv_mode", "downgrade", false);
        bpq = true;
    }

    public static void av(final String str, final String str2) {
        i.execute(new bi() { // from class: com.kwad.sdk.utils.ah.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                try {
                    int iB = bq.b("ksadsdk_kv_perf", str, 0);
                    if (TextUtils.isEmpty(str2)) {
                        bq.ay("ksadsdk_kv_perf", str);
                    } else {
                        bq.a("ksadsdk_kv_perf", str, iB + 1);
                    }
                } catch (Exception e) {
                    bq.ay("ksadsdk_kv_perf", str);
                    ServiceProvider.reportSdkCaughtException(e);
                }
            }
        });
    }

    public static void aw(final String str, final String str2) {
        i.execute(new bi() { // from class: com.kwad.sdk.utils.ah.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                SharedPreferences sharedPreferencesIe = bq.ie("ksadsdk_kv_perf");
                if (sharedPreferencesIe != null && sharedPreferencesIe.contains(str)) {
                    if (TextUtils.isEmpty(str2)) {
                        bq.a("ksadsdk_kv_perf_failed", str, bq.b("ksadsdk_kv_perf_failed", str, 0) + 1);
                    } else {
                        bq.a("ksadsdk_kv_perf_success", str, bq.b("ksadsdk_kv_perf_success", str, 0) + 1);
                    }
                }
            }
        });
    }

    public static void Vd() {
        if (Vg() || Vb() == 0) {
            return;
        }
        i.execute(new bi() { // from class: com.kwad.sdk.utils.ah.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.utils.b.a aVarVe = ah.Ve();
                if (aVarVe == null) {
                    return;
                }
                ah.c(aVarVe);
                com.kwad.sdk.utils.b.b bVar = (com.kwad.sdk.utils.b.b) ServiceProvider.get(com.kwad.sdk.utils.b.b.class);
                if (bVar != null) {
                    bVar.a(aVarVe);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void c(com.kwad.sdk.utils.b.a aVar) {
        if (((double) aVar.bsH) / ((double) (aVar.bsH + aVar.bsI)) > 0.10000000149011612d) {
            bpr = true;
            com.kwad.sdk.core.d.c.d("Ks_UnionHelper", "need downgrade");
            bq.l("kssdk_kv_mode", "downgrade", true);
        }
        if (bpr) {
            Vj();
        }
    }

    public static com.kwad.sdk.utils.b.a Ve() {
        com.kwad.sdk.utils.b.a aVar = new com.kwad.sdk.utils.b.a();
        SharedPreferences sharedPreferencesIe = bq.ie("ksadsdk_kv_perf");
        if (sharedPreferencesIe == null) {
            return null;
        }
        try {
            Map<String, ?> all = sharedPreferencesIe.getAll();
            if (all == null) {
                return null;
            }
            Iterator<Map.Entry<String, ?>> it = all.entrySet().iterator();
            int iIntValue = 0;
            while (it.hasNext()) {
                iIntValue += ((Integer) it.next().getValue()).intValue();
            }
            aVar.bsG = iIntValue;
            SharedPreferences.Editor editorEdit = sharedPreferencesIe.edit();
            Iterator<Map.Entry<String, ?>> it2 = all.entrySet().iterator();
            while (it2.hasNext()) {
                editorEdit.putInt(it2.next().getKey(), 0);
            }
            editorEdit.apply();
            d(aVar);
            e(aVar);
        } catch (Throwable unused) {
        }
        return aVar;
    }

    private static void d(com.kwad.sdk.utils.b.a aVar) {
        SharedPreferences sharedPreferencesIe = bq.ie("ksadsdk_kv_perf_failed");
        int iIntValue = 0;
        if (sharedPreferencesIe != null) {
            Map<String, ?> all = sharedPreferencesIe.getAll();
            if (all != null) {
                Iterator<Map.Entry<String, ?>> it = all.entrySet().iterator();
                while (it.hasNext()) {
                    iIntValue += ((Integer) it.next().getValue()).intValue();
                }
            }
            aVar.bsH = iIntValue;
            SharedPreferences.Editor editorEdit = sharedPreferencesIe.edit();
            editorEdit.clear();
            editorEdit.apply();
            return;
        }
        aVar.bsH = 0;
    }

    private static void e(com.kwad.sdk.utils.b.a aVar) {
        SharedPreferences sharedPreferencesIe = bq.ie("ksadsdk_kv_perf_success");
        int iIntValue = 0;
        if (sharedPreferencesIe != null) {
            Map<String, ?> all = sharedPreferencesIe.getAll();
            if (all != null) {
                Iterator<Map.Entry<String, ?>> it = all.entrySet().iterator();
                while (it.hasNext()) {
                    iIntValue += ((Integer) it.next().getValue()).intValue();
                }
            }
            aVar.bsI = iIntValue;
            SharedPreferences.Editor editorEdit = sharedPreferencesIe.edit();
            editorEdit.clear();
            editorEdit.apply();
            return;
        }
        aVar.bsI = 0;
    }

    private static int Vf() {
        int iB = bq.b("kssdk_kv_mode", "mode", 0);
        com.kwad.sdk.core.d.c.d("Ks_UnionHelper", "local mode:" + iB);
        return iB;
    }

    static void fL(int i) {
        bq.a("kssdk_kv_mode", "mode", i);
    }

    private static boolean Vg() {
        Vc();
        return bpp.get() == 0;
    }

    private static boolean hL(String str) {
        return com.kwad.sdk.j.a.aGe.contains(str);
    }

    public static boolean hM(String str) {
        boolean z = Vg() || !hL(str);
        com.kwad.sdk.core.d.c.d("Ks_UnionHelper", "shouldUseModeSp:" + z);
        return z;
    }

    private static int Vi() {
        Vc();
        int iVb = (bpr || !Vh()) ? 0 : Vb();
        com.kwad.sdk.core.d.c.d("Ks_UnionHelper", "targetMode:" + iVb);
        return iVb;
    }

    public static void Vj() {
        Vc();
        int i = bpp.get();
        int iVi = Vi();
        boolean z = i != iVi;
        com.kwad.sdk.core.d.c.d("Ks_UnionHelper", "needTransfer:" + z);
        if (z) {
            transfer(iVi);
        }
    }

    private static void transfer(int i) {
        if (i == 0) {
            Vk();
        } else if (i == 1) {
            Vl();
        }
    }

    private static void Vk() {
        i.execute(new bi() { // from class: com.kwad.sdk.utils.ah.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                try {
                    Context context = ai.getContext();
                    if (context == null) {
                        return;
                    }
                    Iterator<String> it = com.kwad.sdk.j.a.aGe.iterator();
                    while (it.hasNext()) {
                        ah.Y(context, it.next());
                    }
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.e("Ks_UnionHelper", Log.getStackTraceString(e));
                }
                ah.fL(0);
                ah.bpp.set(0);
            }
        });
    }

    private static void Vl() {
        com.kwad.sdk.core.d.c.d("Ks_UnionHelper", "transferToKv");
        i.execute(new bi() { // from class: com.kwad.sdk.utils.ah.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                try {
                    Context context = ai.getContext();
                    if (context != null) {
                        Iterator<String> it = com.kwad.sdk.j.a.aGe.iterator();
                        while (it.hasNext()) {
                            ah.X(context, it.next());
                        }
                        ah.fL(1);
                        ah.bpp.set(1);
                    }
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.e("Ks_UnionHelper", Log.getStackTraceString(e));
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void X(Context context, String str) {
        SharedPreferences sharedPreferencesIe;
        com.kwad.sdk.utils.a.c cVarAF = com.kwad.sdk.utils.a.e.aF(context, str);
        if ("ksadsdk_splash_preload_id_list".equals(str) && (sharedPreferencesIe = bq.ie(str)) == null) {
            SharedPreferences.Editor editorEdit = sharedPreferencesIe.edit();
            if (editorEdit != null) {
                editorEdit.remove("kv_to_sp_transfer_flag").remove("sp_to_kv_transfer_flag").apply();
                return;
            }
            return;
        }
        if (cVarAF.contains("sp_to_kv_transfer_flag")) {
            return;
        }
        SharedPreferences sharedPreferencesIe2 = bq.ie(str);
        if (sharedPreferencesIe2 == null) {
            cVarAF.putBoolean("sp_to_kv_transfer_flag", true);
            return;
        }
        cVarAF.putAll(sharedPreferencesIe2.getAll());
        cVarAF.putBoolean("sp_to_kv_transfer_flag", true);
        bq.ay(str, "kv_to_sp_transfer_flag");
        a(str, cVarAF);
    }

    private static void a(String str, com.kwad.sdk.utils.a.c cVar) {
        if (com.kwad.sdk.j.a.aGf.contains(str)) {
            return;
        }
        cVar.release();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void Y(Context context, String str) {
        SharedPreferences sharedPreferencesIe = bq.ie(str);
        if (sharedPreferencesIe == null) {
            return;
        }
        if ("ksadsdk_splash_preload_id_list".equals(str)) {
            SharedPreferences.Editor editorEdit = sharedPreferencesIe.edit();
            if (editorEdit != null) {
                editorEdit.remove("kv_to_sp_transfer_flag").remove("sp_to_kv_transfer_flag").apply();
                return;
            }
            return;
        }
        if (sharedPreferencesIe.contains("kv_to_sp_transfer_flag")) {
            return;
        }
        com.kwad.sdk.utils.a.c cVarAF = com.kwad.sdk.utils.a.e.aF(context, str);
        Map<String, Object> all = cVarAF.getAll();
        if (all.isEmpty()) {
            bq.l(str, "kv_to_sp_transfer_flag", true);
            return;
        }
        bq.a(str, all);
        bq.l(str, "kv_to_sp_transfer_flag", true);
        cVarAF.remove("sp_to_kv_transfer_flag");
        cVarAF.release();
    }
}
