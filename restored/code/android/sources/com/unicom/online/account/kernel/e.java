package com.unicom.online.account.kernel;

/* JADX INFO: loaded from: classes4.dex */
public final class e implements Runnable {
    public final /* synthetic */ int b;
    public final /* synthetic */ i c;

    public e(i iVar, int i) {
        this.c = iVar;
        this.b = i;
    }

    @Override // java.lang.Runnable
    public final void run() {
        i iVar = this.c;
        int i = this.b;
        synchronized (iVar) {
            av avVar = iVar.e;
            if (avVar != null) {
                avVar.b(i, 410000, "请求超时", "", bp.c());
                iVar.e = null;
                as.b("end:" + System.currentTimeMillis() + "", 3);
            }
            iVar.b("超时处理");
        }
    }
}
