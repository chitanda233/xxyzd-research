package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.content.res.Resources;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

/* JADX INFO: loaded from: classes2.dex */
public class O {
    private static volatile O e;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1951a;
    private Resources b;
    private LayoutInflater c;
    private int d = 0;

    private O(Context context) {
        this.f1951a = null;
        if (context != null) {
            this.f1951a = context.getApplicationContext();
        }
        this.b = this.f1951a.getResources();
        this.c = LayoutInflater.from(this.f1951a);
    }

    public static O a(Context context) {
        if (e == null) {
            try {
                e = new O(context);
            } catch (Exception e2) {
                e2.printStackTrace();
                Q.d("ExceptionShanYanLogger", "LCMResource  Exception_e=", e2);
            }
        }
        return e;
    }

    public int b(String str) {
        Resources resources = this.b;
        return resources != null ? resources.getIdentifier(str, "id", C0616v.g().c(this.f1951a)) : this.d;
    }

    public View c(String str) {
        Resources resources = this.b;
        if (resources != null) {
            int identifier = resources.getIdentifier(str, "layout", C0616v.g().c(this.f1951a));
            LayoutInflater layoutInflater = this.c;
            if (layoutInflater != null && identifier != 0) {
                return layoutInflater.inflate(identifier, (ViewGroup) null);
            }
        }
        return null;
    }

    public int a(String str) {
        try {
            Resources resources = this.b;
            if (resources != null) {
                return resources.getIdentifier(str, "anim", C0616v.g().c(this.f1951a));
            }
            return this.d;
        } catch (Exception e2) {
            e2.printStackTrace();
            return this.d;
        }
    }
}
