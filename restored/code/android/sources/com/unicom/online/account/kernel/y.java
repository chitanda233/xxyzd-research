package com.unicom.online.account.kernel;

import android.net.Network;
import java.util.TimerTask;

/* JADX INFO: loaded from: classes4.dex */
public final class y extends TimerTask {
    public final /* synthetic */ ab b;

    public y(ab abVar) {
        this.b = abVar;
    }

    @Override // java.util.TimerTask, java.lang.Runnable
    public final void run() {
        this.b.b(false, (Network) null);
    }
}
