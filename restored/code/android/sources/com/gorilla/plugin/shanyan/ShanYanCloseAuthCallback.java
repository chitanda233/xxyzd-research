package com.gorilla.plugin.shanyan;

/* JADX INFO: loaded from: classes3.dex */
public final class ShanYanCloseAuthCallback {
    private static volatile Listener sListener;

    public interface Listener {
        void onCloseAuth();
    }

    private ShanYanCloseAuthCallback() {
    }

    public static void setListener(Listener listener) {
        sListener = listener;
    }

    public static void fire() {
        Listener listener = sListener;
        if (listener != null) {
            listener.onCloseAuth();
        }
    }
}
