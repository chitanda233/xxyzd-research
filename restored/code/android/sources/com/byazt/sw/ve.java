package com.byazt.sw;

import android.os.Handler;
import android.os.Message;
import com.byazt.nr.da;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 868, 54})
public class ve implements Handler.Callback {
    public Handler c;

    @com.byazt.zqa.c(c = {0, 1, 868, 24})
    private static class c {
        public static final ve c = new ve();
    }

    public static ve c() {
        return c.c;
    }

    private ve() {
        this.c = new Handler(da.c().getLooper(), this);
    }

    public void c(Runnable runnable) {
        Message messageObtain = Message.obtain();
        messageObtain.obj = runnable;
        this.c.sendMessage(messageObtain);
    }

    @Override // android.os.Handler.Callback
    public boolean handleMessage(Message message) {
        ((Runnable) message.obj).run();
        return false;
    }

    public void c(Runnable runnable, long j) {
        this.c.postDelayed(runnable, j);
    }
}
