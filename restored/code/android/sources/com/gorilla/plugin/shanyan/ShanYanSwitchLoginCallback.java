package com.gorilla.plugin.shanyan;

/* JADX INFO: loaded from: classes3.dex */
public final class ShanYanSwitchLoginCallback {
    private static volatile Listener sListener;

    public interface Listener {
        void onSwitchLogin();
    }

    public static void setListener(Listener listener) {
        sListener = listener;
    }

    public static void fire() {
        Listener listener = sListener;
        if (listener != null) {
            listener.onSwitchLogin();
        }
    }
}
