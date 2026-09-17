package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import cn.thinkingdata.core.exception.TDHttpException;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes4.dex */
public class TuringIDService {
    public static ITuringDID getTuringDID(Context context) {
        int iA = d0.a();
        return new v(iA != 0 ? new h(iA, 0, 0) : n.l.a(context, true, 1));
    }

    public static void getTuringDIDAsync(Context context, ITuringDIDCallback iTuringDIDCallback) {
        if (iTuringDIDCallback == null) {
            return;
        }
        u uVar = new u(iTuringDIDCallback);
        AtomicBoolean atomicBoolean = d0.b;
        if (context.getApplicationContext() == null) {
            iTuringDIDCallback.onResult(new v(new h(-10016, 0, 0)));
            return;
        }
        int iA = d0.a();
        if (iA != 0) {
            iTuringDIDCallback.onResult(new v(new h(iA, 0, 0)));
        }
        new c0(uVar, context).start();
    }

    public static ITuringDID getTuringDIDCached(Context context) {
        h hVarC;
        int iA = d0.a();
        if (iA != 0) {
            hVarC = new h(iA, 0, 0);
        } else {
            n nVar = n.l;
            hVarC = nVar.c(context);
            if (nVar.f3947a == null) {
                hVarC = new h(TDHttpException.ERROR_EXCEPTION, 0, 0);
            } else {
                int iA2 = nVar.a(hVarC);
                if (iA2 != 1) {
                    if (iA2 == 2) {
                        nVar.a();
                        hVarC = new h(-10009, 0, 0);
                    } else if (iA2 == 3) {
                        nVar.a();
                    }
                }
            }
        }
        return new v(hVarC);
    }
}
