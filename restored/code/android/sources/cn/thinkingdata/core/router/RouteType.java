package cn.thinkingdata.core.router;

/* JADX INFO: loaded from: classes.dex */
public enum RouteType {
    PROVIDER,
    PLUGIN,
    UNKNOWN;

    public static RouteType parse(int i) {
        if (i != 0) {
            return i != 1 ? UNKNOWN : PLUGIN;
        }
        return PROVIDER;
    }
}
