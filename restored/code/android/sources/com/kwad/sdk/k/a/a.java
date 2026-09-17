package com.kwad.sdk.k.a;

import android.content.Context;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a implements c {
    protected List<c> bms;
    protected boolean enabled;

    protected boolean cG(Context context) {
        return false;
    }

    public a(boolean z) {
        this.enabled = z;
    }

    public a() {
        this.enabled = true;
    }

    @Override // com.kwad.sdk.k.a.c
    public final boolean cF(Context context) {
        if (!this.enabled) {
            return false;
        }
        List<c> children = getChildren();
        if (children != null && children.size() > 0) {
            Iterator<c> it = children.iterator();
            while (it.hasNext()) {
                if (it.next().cF(context)) {
                    return true;
                }
            }
            return false;
        }
        try {
            return cG(context);
        } catch (Throwable unused) {
            return false;
        }
    }

    private List<c> getChildren() {
        return this.bms;
    }
}
