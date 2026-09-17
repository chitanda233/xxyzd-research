package cn.thinkingdata.core.router;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
public final class TRouter {
    private static volatile boolean hasInit = false;
    private static volatile TRouter instance;

    private TRouter() {
    }

    public static TRouter getInstance() {
        if (!hasInit) {
            throw new InitException("TRouter::Init::Invoke init(context) first!");
        }
        if (instance == null) {
            synchronized (TRouter.class) {
                if (instance == null) {
                    instance = new TRouter();
                }
            }
        }
        return instance;
    }

    public static void init() {
        if (hasInit) {
            return;
        }
        hasInit = _TRouter.init();
    }

    public Postcard build(String str) {
        return _TRouter.getInstance().build(str);
    }

    public Object navigation(Context context, Postcard postcard) {
        return _TRouter.getInstance().navigation(context, postcard);
    }
}
