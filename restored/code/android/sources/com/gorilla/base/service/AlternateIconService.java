package com.gorilla.base.service;

import android.app.Activity;
import android.content.ComponentName;
import android.content.pm.ActivityInfo;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import java.util.ArrayList;
import java.util.List;
import java.util.regex.Pattern;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class AlternateIconService {
    private static final String ALTERNATE_ALIAS_SUFFIX_PREFIX = ".GorillaAlternateIcon_";
    private static final String DEFAULT_ALIAS_SUFFIX = ".GorillaAlternateIconDefault";
    private static final String DEFAULT_ICON_NAME = "default";
    private static final Pattern ICON_NAME_PATTERN = Pattern.compile("^[a-z0-9_]+$");

    private static int getPackageInfoFlags() {
        return 513;
    }

    public static void setAlternateIcon(Activity activity, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        if (activity == null) {
            notifyFailure(iFailureCallback, -1, "Activity is null.");
            return;
        }
        String strOptString = jSONObject != null ? jSONObject.optString("iconName", null) : null;
        if (strOptString == null || strOptString.trim().isEmpty()) {
            notifyFailure(iFailureCallback, -2, "iconName is required.");
            return;
        }
        String strTrim = strOptString.trim();
        if (!DEFAULT_ICON_NAME.equalsIgnoreCase(strTrim) && !ICON_NAME_PATTERN.matcher(strTrim).matches()) {
            notifyFailure(iFailureCallback, -3, "Invalid iconName.");
            return;
        }
        String packageName = activity.getPackageName();
        String str = DEFAULT_ICON_NAME.equalsIgnoreCase(strTrim) ? DEFAULT_ALIAS_SUFFIX : ALTERNATE_ALIAS_SUFFIX_PREFIX + strTrim;
        PackageManager packageManager = activity.getPackageManager();
        List<String> listCollectGeneratedAliases = collectGeneratedAliases(packageManager, packageName);
        String strFindAliasBySuffix = findAliasBySuffix(listCollectGeneratedAliases, str);
        if (strFindAliasBySuffix == null) {
            notifyFailure(iFailureCallback, -4, "Alternate icon alias not found: " + str);
            return;
        }
        try {
            setAliasEnabled(packageManager, packageName, strFindAliasBySuffix, true);
            for (String str2 : listCollectGeneratedAliases) {
                if (!strFindAliasBySuffix.equals(str2)) {
                    setAliasEnabled(packageManager, packageName, str2, false);
                }
            }
            if (iSuccessCallback != null) {
                if (DEFAULT_ICON_NAME.equalsIgnoreCase(strTrim)) {
                    strTrim = DEFAULT_ICON_NAME;
                }
                iSuccessCallback.onSuccess(new JSONObject().put("iconName", strTrim).toString());
            }
        } catch (Exception e) {
            notifyFailure(iFailureCallback, -5, "Failed to set alternate icon: " + e.getMessage());
        }
    }

    private static List<String> collectGeneratedAliases(PackageManager packageManager, String str) {
        ArrayList arrayList = new ArrayList();
        try {
            PackageInfo packageInfo = packageManager.getPackageInfo(str, getPackageInfoFlags());
            if (packageInfo.activities == null) {
                return arrayList;
            }
            for (ActivityInfo activityInfo : packageInfo.activities) {
                if (activityInfo != null && activityInfo.name != null && (activityInfo.name.endsWith(DEFAULT_ALIAS_SUFFIX) || activityInfo.name.contains(ALTERNATE_ALIAS_SUFFIX_PREFIX))) {
                    arrayList.add(activityInfo.name);
                }
            }
        } catch (Exception unused) {
        }
        return arrayList;
    }

    private static String findAliasBySuffix(List<String> list, String str) {
        for (String str2 : list) {
            if (str2 != null && str2.endsWith(str)) {
                return str2;
            }
        }
        return null;
    }

    private static void setAliasEnabled(PackageManager packageManager, String str, String str2, boolean z) {
        packageManager.setComponentEnabledSetting(new ComponentName(str, str2), z ? 1 : 2, 1);
    }

    private static void notifyFailure(IFailureCallback iFailureCallback, int i, String str) {
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(i, str);
        }
    }
}
