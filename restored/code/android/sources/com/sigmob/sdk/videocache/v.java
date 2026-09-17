package com.sigmob.sdk.videocache;

import android.content.Context;
import com.czhj.sdk.logger.SigmobLog;
import java.io.File;

/* JADX INFO: loaded from: classes4.dex */
final class v {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3682a = "video-cache";

    v() {
    }

    public static File a(Context context) {
        return new File(a(context, true), f3682a);
    }

    private static File a(Context context, boolean preferExternal) {
        File cacheDir = context.getCacheDir();
        if (cacheDir != null) {
            return cacheDir;
        }
        String str = "/data/data/" + context.getPackageName() + "/cache/";
        SigmobLog.w("Can't define system cache directory! '" + str + "%s' will be used.");
        return new File(str);
    }
}
