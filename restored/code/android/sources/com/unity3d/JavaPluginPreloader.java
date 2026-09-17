package com.unity3d;

import android.util.Log;
import com.unity3d.adaptiveperformance.samsung.GameLoadBooster;

/* JADX INFO: loaded from: classes4.dex */
public class JavaPluginPreloader {
    static {
        loadJavaClass(GameLoadBooster.class.getName());
    }

    private static void loadJavaClass(String str) {
        try {
            Class.forName(str);
        } catch (ClassNotFoundException e) {
            Log.e("Unity", "Failed to load class", e);
        } catch (LinkageError e2) {
            Log.e("Unity", "Failed to load class", e2);
        }
    }
}
