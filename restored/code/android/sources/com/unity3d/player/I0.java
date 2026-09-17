package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class I0 implements Runnable {
    I0() {
    }

    @Override // java.lang.Runnable
    public final void run() {
        try {
            AbstractC0705c.a();
        } catch (Exception e) {
            AbstractC0751z.Log(6, "Exception when hiding Activity Indicator " + e);
        }
    }
}
