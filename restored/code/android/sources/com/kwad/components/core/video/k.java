package com.kwad.components.core.video;

import android.content.Context;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.an;
import java.io.File;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class k {
    private static Map<String, Integer> anX = new ConcurrentHashMap();

    public static boolean a(String str, String str2, com.kwad.sdk.core.network.a.a.C0515a c0515a) {
        String strMd5 = an.md5(str2);
        long jCurrentTimeMillis = System.currentTimeMillis();
        com.kwad.sdk.core.d.c.i("VideoCacheHelper", "start cache video key:" + strMd5 + "--url:" + str);
        boolean zB = com.kwad.sdk.core.diskcache.b.a.LI().b(str, str2, c0515a);
        com.kwad.sdk.core.d.c.i("VideoCacheHelper", "finish cache video key:" + strMd5 + "--cache time:" + (System.currentTimeMillis() - jCurrentTimeMillis) + "--success:" + zB);
        return zB;
    }

    public static boolean bd(AdTemplate adTemplate) {
        File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(com.kwad.sdk.core.response.helper.a.M(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
        return fileCM != null && fileCM.exists();
    }

    public static String j(Context context, AdTemplate adTemplate) {
        return a(context, com.kwad.sdk.core.response.helper.e.fc(adTemplate), com.kwad.sdk.core.response.helper.a.M(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
    }

    public static String k(Context context, String str) {
        return a(context, bo(str), str);
    }

    private static String a(Context context, int i, String str) {
        if (i >= 0) {
            return i > 0 ? com.kwad.sdk.core.videocache.c.a.cl(context).fv(str) : str;
        }
        File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(str);
        return (fileCM == null || !fileCM.exists()) ? str : fileCM.getAbsolutePath();
    }

    public static void n(String str, int i) {
        anX.put(str, Integer.valueOf(i));
    }

    private static int bo(String str) {
        Integer num = anX.get(str);
        if (num != null) {
            return num.intValue();
        }
        return com.kwad.sdk.core.config.e.Gm();
    }
}
