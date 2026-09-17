package com.gorilla.base.util;

import android.content.Context;
import android.net.Uri;
import android.text.TextUtils;
import androidx.core.content.FileProvider;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public final class GorillaFileProviderUtils {
    private GorillaFileProviderUtils() {
    }

    public static String getAuthority(Context context) {
        return context == null ? "" : context.getPackageName() + ".gorilla.fileprovider";
    }

    public static Uri getUriForFile(Context context, File file) {
        if (context != null && file != null) {
            try {
                return FileProvider.getUriForFile(context, getAuthority(context), file);
            } catch (IllegalArgumentException unused) {
            }
        }
        return null;
    }

    public static void grantReadUriPermission(Context context, String str, Uri uri) {
        if (context == null || uri == null || TextUtils.isEmpty(str)) {
            return;
        }
        try {
            context.grantUriPermission(str, uri, 1);
        } catch (Exception unused) {
        }
    }
}
