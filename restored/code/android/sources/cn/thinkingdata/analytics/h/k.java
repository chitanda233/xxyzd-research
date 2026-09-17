package cn.thinkingdata.analytics.h;

import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public enum k {
    TRACK("track"),
    TRACK_UPDATE("track_update"),
    TRACK_OVERWRITE("track_overwrite"),
    USER_ADD("user_add"),
    USER_SET("user_set"),
    USER_SET_ONCE("user_setOnce"),
    USER_UNSET("user_unset"),
    USER_APPEND("user_append"),
    USER_DEL("user_del"),
    USER_UNIQ_APPEND("user_uniq_append");

    private static final Map<String, k> l = new HashMap();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String f121a;

    static {
        for (k kVar : values()) {
            l.put(kVar.a(), kVar);
        }
    }

    k(String str) {
        this.f121a = str;
    }

    public static k a(String str) {
        return l.get(str);
    }

    public String a() {
        return this.f121a;
    }

    public boolean b() {
        return this == TRACK || this == TRACK_OVERWRITE || this == TRACK_UPDATE;
    }
}
