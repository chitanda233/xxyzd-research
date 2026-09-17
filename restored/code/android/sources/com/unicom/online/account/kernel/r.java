package com.unicom.online.account.kernel;

import java.util.ArrayList;

/* JADX INFO: loaded from: classes4.dex */
public final class r implements Runnable {
    public final /* synthetic */ ArrayList b;
    public final /* synthetic */ s c;

    public r(s sVar, ArrayList arrayList) {
        this.c = sVar;
        this.b = arrayList;
    }

    @Override // java.lang.Runnable
    public final void run() {
        try {
            s sVar = this.c;
            sVar.b.b(sVar.e, sVar.d, this.b);
        } catch (Exception e) {
            e.getMessage();
            as.b(e);
        }
    }
}
