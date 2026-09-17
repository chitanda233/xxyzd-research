package com.chuanglan.shanyan_sdk.tool;

import android.content.Context;
import com.chuanglan.shanyan_sdk.AbstractC0610p;
import com.chuanglan.shanyan_sdk.C0616v;

/* JADX INFO: loaded from: classes2.dex */
public class CheckAuthTool {
    public boolean checkAuthEnable(Context context) {
        return AbstractC0610p.a(context);
    }

    public int currentSimCounts(Context context) {
        return C0616v.g().e(context);
    }
}
