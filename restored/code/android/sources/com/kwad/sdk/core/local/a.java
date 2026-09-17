package com.kwad.sdk.core.local;

import android.content.Context;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.request.model.f;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private static volatile a aSN;
    public static ThreadLocal<SimpleDateFormat> aSO = new ThreadLocal<SimpleDateFormat>() { // from class: com.kwad.sdk.core.local.a.1
        @Override // java.lang.ThreadLocal
        protected final /* synthetic */ SimpleDateFormat initialValue() {
            return Mo();
        }

        private static SimpleDateFormat Mo() {
            return new SimpleDateFormat("yyyy-MM-dd");
        }
    };

    public static a Mj() {
        if (aSN == null) {
            synchronized (a.class) {
                if (aSN == null) {
                    aSN = new a();
                }
            }
        }
        return aSN;
    }

    public static boolean Mk() {
        List<f> listEm = em(15);
        if (listEm.size() == 0) {
            return true;
        }
        long j = -1;
        int i = 0;
        for (f fVar : listEm) {
            i += fVar.count;
            if (fVar.aXx > j) {
                j = fVar.aXx;
            }
        }
        c.d("AdCounter", "onBind localCountCheck: allCount: " + i + ", lastShowTime: " + j);
        if (i > Mm()) {
            return false;
        }
        return j + (Mn() * 1000) <= System.currentTimeMillis();
    }

    public static void cB(AdTemplate adTemplate) {
        if (adTemplate.watched) {
            c.d("AdCounter", "startWatchAd this ad has been watched.");
        } else {
            cC(adTemplate);
        }
    }

    public static List<f> Ml() {
        if (((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext() == null) {
            return null;
        }
        String string = getString("ksadsdk_local_ad_task_info_adstyle_data");
        ArrayList<f> arrayList = new ArrayList();
        try {
            JSONArray jSONArray = new JSONArray(string);
            int length = jSONArray.length();
            for (int i = 0; i < length; i++) {
                JSONObject jSONObject = jSONArray.getJSONObject(i);
                f fVar = new f();
                fVar.parseJson(jSONObject);
                arrayList.add(fVar);
            }
        } catch (Exception unused) {
        }
        ArrayList arrayList2 = new ArrayList();
        for (f fVar2 : arrayList) {
            if (a(fVar2)) {
                arrayList2.add(fVar2);
            }
        }
        return arrayList2;
    }

    private static List<f> em(int i) {
        ArrayList arrayList = new ArrayList();
        List<f> listMl = Ml();
        if (listMl != null && listMl.size() != 0) {
            for (f fVar : listMl) {
                if (15 == fVar.adStyle) {
                    arrayList.add(fVar);
                }
            }
        }
        return arrayList;
    }

    public static void g(int i, long j) {
        Context context = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext();
        if (context == null) {
            return;
        }
        context.getSharedPreferences("ksadsdk_local_ad_task_info", 0).edit().putInt("reward_aggregation_max_per_day", i).putLong("reward_aggregation_min_interval", j).apply();
    }

    private static int Mm() {
        Context context = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext();
        if (context == null) {
            return 30;
        }
        return context.getSharedPreferences("ksadsdk_local_ad_task_info", 0).getInt("reward_aggregation_max_per_day", 30);
    }

    private static long Mn() {
        Context context = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext();
        if (context == null) {
            return 1200L;
        }
        return context.getSharedPreferences("ksadsdk_local_ad_task_info", 0).getLong("reward_aggregation_min_interval", 1200L);
    }

    private static boolean a(f fVar) {
        long j = fVar.aXx;
        if (j <= 0) {
            return false;
        }
        SimpleDateFormat simpleDateFormat = aSO.get();
        return simpleDateFormat.format(new Date(j)).equals(simpleDateFormat.format(new Date()));
    }

    private static void cC(AdTemplate adTemplate) {
        boolean z;
        int iEU = e.eU(adTemplate);
        int iEG = e.eG(adTemplate);
        List listMl = Ml();
        if (listMl == null || listMl.size() == 0) {
            listMl = new ArrayList();
            listMl.add(new f(iEG, iEU, 1, System.currentTimeMillis()));
        } else {
            Iterator it = listMl.iterator();
            while (true) {
                if (!it.hasNext()) {
                    z = false;
                    break;
                }
                f fVar = (f) it.next();
                if (fVar.adStyle == iEG && fVar.taskType == iEU) {
                    fVar.count++;
                    if (!a(fVar)) {
                        fVar.count = 1;
                        fVar.aI(System.currentTimeMillis());
                    }
                    z = true;
                    break;
                }
            }
            if (!z) {
                listMl.add(new f(iEG, iEU, 1, System.currentTimeMillis()));
            }
        }
        S("ksadsdk_local_ad_task_info_adstyle_data", ac.Y(listMl).toString());
        adTemplate.watched = true;
    }

    private static void S(String str, String str2) {
        Context context = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext();
        if (context == null) {
            return;
        }
        context.getSharedPreferences("ksadsdk_local_ad_task_info", 0).edit().putString(str, str2).apply();
    }

    private static String getString(String str) {
        Context context = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext();
        if (context == null) {
            return null;
        }
        try {
            return context.getSharedPreferences("ksadsdk_local_ad_task_info", 0).getString(str, null);
        } catch (Throwable th) {
            c.printStackTrace(th);
            return null;
        }
    }
}
