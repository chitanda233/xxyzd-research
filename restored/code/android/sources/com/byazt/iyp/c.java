package com.byazt.iyp;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Map;
import org.json.JSONArray;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_QUIC_FIX_PROCESS_TIMER, 20})
public final class c {
    public static volatile long c;
    public static volatile long tt;
    public static final Map<String, tt<JSONArray>> uj;
    public static final Map<String, tt<C0157c>> ve;

    static {
        int i = 16;
        float f = 0.75f;
        boolean z = false;
        ve = Collections.synchronizedMap(new LinkedHashMap<String, tt<C0157c>>(i, f, z) { // from class: com.byazt.iyp.c.1
            @Override // java.util.LinkedHashMap
            public boolean removeEldestEntry(Map.Entry<String, tt<C0157c>> entry) {
                return size() > 256;
            }
        });
        uj = Collections.synchronizedMap(new LinkedHashMap<String, tt<JSONArray>>(i, f, z) { // from class: com.byazt.iyp.c.2
            @Override // java.util.LinkedHashMap
            public boolean removeEldestEntry(Map.Entry<String, tt<JSONArray>> entry) {
                return size() > 256;
            }
        });
    }

    public static void c(String str, C0157c c0157c) {
        if (str == null || c0157c == null) {
            return;
        }
        ve.put(str, new tt<>(c0157c, c()));
        tt();
    }

    public static C0157c c(String str) {
        tt<C0157c> ttVarRemove;
        if (str == null || (ttVarRemove = ve.remove(str)) == null || c(ttVarRemove.tt, 300000L)) {
            return null;
        }
        return ttVarRemove.c;
    }

    public static C0157c tt(String str) {
        Map<String, tt<C0157c>> map;
        tt<C0157c> ttVar;
        if (str == null || (ttVar = (map = ve).get(str)) == null) {
            return null;
        }
        if (c(ttVar.tt, 300000L)) {
            map.remove(str);
            return null;
        }
        return ttVar.c;
    }

    public static void c(String str, JSONArray jSONArray, String str2) {
        if (str == null) {
            return;
        }
        Map<String, tt<C0157c>> map = ve;
        synchronized (map) {
            tt<C0157c> ttVar = map.get(str);
            if (ttVar == null) {
                return;
            }
            if (c(ttVar.tt, 300000L)) {
                map.remove(str);
                return;
            }
            C0157c c0157c = ttVar.c;
            if (c0157c == null) {
                return;
            }
            c0157c.n = jSONArray;
            if (TextUtils.isEmpty(str2)) {
                str2 = " ";
            }
            c0157c.f1054a = str2;
        }
    }

    public static void c(String str, JSONArray jSONArray) {
        if (str == null || jSONArray == null) {
            return;
        }
        uj.put(str, new tt<>(jSONArray, c()));
        ve();
    }

    public static JSONArray ve(String str) {
        tt<JSONArray> ttVarRemove;
        if (str == null || (ttVarRemove = uj.remove(str)) == null || c(ttVarRemove.tt, 600000L)) {
            return null;
        }
        return ttVarRemove.c;
    }

    private static long c() {
        return System.currentTimeMillis();
    }

    private static boolean c(long j, long j2) {
        return j2 > 0 && c() - j >= j2;
    }

    private static void tt() {
        long jC = c();
        if (jC - c < 30000) {
            return;
        }
        c = jC;
        c(ve, 300000L, jC);
    }

    private static void ve() {
        long jC = c();
        if (jC - tt < 30000) {
            return;
        }
        tt = jC;
        c(uj, 600000L, jC);
    }

    private static <T> void c(Map<String, tt<T>> map, long j, long j2) {
        if (j <= 0) {
            return;
        }
        synchronized (map) {
            Iterator<Map.Entry<String, tt<T>>> it = map.entrySet().iterator();
            while (it.hasNext()) {
                tt<T> value = it.next().getValue();
                if (value == null || j2 - value.tt >= j) {
                    it.remove();
                }
            }
        }
    }

    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_QUIC_FIX_PROCESS_TIMER, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_AVERAGE_PLAY_SPEED})
    private static final class tt<T> {
        public final T c;
        public final long tt;

        public tt(T t, long j) {
            this.c = t;
            this.tt = j;
        }
    }

    /* JADX INFO: renamed from: com.byazt.iyp.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_QUIC_FIX_PROCESS_TIMER, 44})
    public static final class C0157c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f1054a;
        public final String c;
        public JSONArray n;
        public final String sp;
        public final String tt;
        public final Boolean uj;
        public final String ve;

        public C0157c(String str, String str2, String str3, Boolean bool, JSONArray jSONArray, String str4, String str5) {
            this.c = TextUtils.isEmpty(str) ? " " : str;
            this.tt = TextUtils.isEmpty(str2) ? " " : str2;
            this.ve = TextUtils.isEmpty(str3) ? " " : str3;
            this.uj = bool;
            this.n = jSONArray;
            this.f1054a = TextUtils.isEmpty(str4) ? " " : str4;
            this.sp = TextUtils.isEmpty(str5) ? " " : str5;
        }
    }
}
