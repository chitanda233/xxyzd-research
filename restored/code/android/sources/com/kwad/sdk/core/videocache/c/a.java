package com.kwad.sdk.core.videocache.c;

import android.content.Context;
import com.kwad.sdk.core.videocache.f;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static f baG;

    public static f cl(Context context) {
        return b(context, 0, 0);
    }

    public static f b(Context context, int i, int i2) {
        f fVar = baG;
        if (fVar != null) {
            return fVar;
        }
        f fVarC = c(context, i, i2);
        baG = fVarC;
        return fVarC;
    }

    private static f c(Context context, int i, int i2) {
        return new f.a(context).aL(536870912L).eD(i).eE(i2).Ph();
    }
}
