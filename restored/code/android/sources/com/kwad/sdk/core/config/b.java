package com.kwad.sdk.core.config;

import android.content.Context;
import android.content.SharedPreferences;
import android.text.TextUtils;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bq;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.CopyOnWriteArraySet;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static final Map<String, Set<com.kwad.sdk.core.config.item.b>> aMW = new ConcurrentHashMap();
    private static SharedPreferences aMX = null;

    public static <T> void a(com.kwad.sdk.core.config.item.b<T> bVar) {
        String key = bVar.getKey();
        if (TextUtils.isEmpty(key)) {
            return;
        }
        Set<com.kwad.sdk.core.config.item.b> setEg = eg(key);
        if (setEg == null) {
            setEg = new CopyOnWriteArraySet<>();
            aMW.put(key, setEg);
        }
        setEg.add(bVar);
    }

    private static Set<com.kwad.sdk.core.config.item.b> eg(String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        return aMW.get(str);
    }

    public static void k(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        for (String str : aMW.keySet()) {
            Set<com.kwad.sdk.core.config.item.b> set = aMW.get(str);
            if (set != null && !set.isEmpty() && jSONObject.has(str)) {
                for (com.kwad.sdk.core.config.item.b bVar : set) {
                    if (bVar != null) {
                        bVar.l(jSONObject);
                    }
                }
            }
        }
    }

    private static SharedPreferences Ju() {
        if (aMX == null) {
            aMX = bq.ie("ksadsdk_config");
        }
        return aMX;
    }

    public static synchronized void bK(Context context) {
        try {
            SharedPreferences sharedPreferencesJu = Ju();
            if (sharedPreferencesJu != null) {
                SharedPreferences.Editor editorEdit = sharedPreferencesJu.edit();
                a(editorEdit);
                editorEdit.commit();
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static synchronized void bL(Context context) {
        SharedPreferences sharedPreferencesJu = Ju();
        if (sharedPreferencesJu != null) {
            a(sharedPreferencesJu);
        }
    }

    private static void a(SharedPreferences.Editor editor) {
        if (editor != null) {
            Iterator<String> it = aMW.keySet().iterator();
            while (it.hasNext()) {
                Set<com.kwad.sdk.core.config.item.b> set = aMW.get(it.next());
                if (set != null && !set.isEmpty()) {
                    for (com.kwad.sdk.core.config.item.b bVar : set) {
                        if (bVar != null) {
                            bVar.b(editor);
                        }
                    }
                }
            }
        }
    }

    private static void a(SharedPreferences sharedPreferences) {
        if (sharedPreferences != null) {
            Iterator<String> it = aMW.keySet().iterator();
            while (it.hasNext()) {
                Set<com.kwad.sdk.core.config.item.b> set = aMW.get(it.next());
                if (set != null && !set.isEmpty()) {
                    for (com.kwad.sdk.core.config.item.b bVar : set) {
                        if (bVar != null) {
                            try {
                                bVar.a(sharedPreferences);
                            } catch (Exception e) {
                                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                            }
                        }
                    }
                }
            }
        }
    }

    static void a(Context context, com.kwad.sdk.core.config.item.b<?> bVar) {
        SharedPreferences sharedPreferencesJu;
        if (bVar == null || (sharedPreferencesJu = Ju()) == null) {
            return;
        }
        try {
            bVar.a(sharedPreferencesJu);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }
}
