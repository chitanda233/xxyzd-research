package com.chuanglan.shanyan_sdk;

import android.view.View;
import android.view.ViewGroup;

/* JADX INFO: loaded from: classes2.dex */
public abstract class x0 {
    public static void a(View view) {
        if (view == null) {
            return;
        }
        if (!(view instanceof ViewGroup)) {
            view.setOnClickListener(null);
            return;
        }
        try {
            ViewGroup viewGroup = (ViewGroup) view;
            int childCount = viewGroup.getChildCount();
            for (int i = 0; i < childCount; i++) {
                a(viewGroup.getChildAt(i));
            }
            viewGroup.removeAllViews();
            viewGroup.setOnClickListener(null);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
