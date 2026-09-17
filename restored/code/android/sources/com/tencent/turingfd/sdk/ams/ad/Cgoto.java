package com.tencent.turingfd.sdk.ams.ad;

import android.accessibilityservice.AccessibilityServiceInfo;
import android.content.ComponentName;
import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.ResolveInfo;
import android.content.pm.ServiceInfo;
import android.provider.Settings;
import android.text.TextUtils;
import android.view.accessibility.AccessibilityManager;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.goto, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Cgoto {
    public static boolean a(AccessibilityServiceInfo accessibilityServiceInfo) {
        ServiceInfo serviceInfo;
        ApplicationInfo applicationInfo;
        ResolveInfo resolveInfo = accessibilityServiceInfo.getResolveInfo();
        if (resolveInfo != null && (serviceInfo = resolveInfo.serviceInfo) != null && (applicationInfo = serviceInfo.applicationInfo) != null) {
            if (applicationInfo.uid < 10000) {
                return true;
            }
            if (!TextUtils.isEmpty(applicationInfo.sourceDir) && !applicationInfo.sourceDir.startsWith("/data/")) {
                return true;
            }
            Object objA = Filbert.a(ApplicationInfo.class, "seInfo", applicationInfo);
            if (objA instanceof String) {
                String str = (String) objA;
                if (str.contains("partition=product") || str.contains("partition=system_ext")) {
                    return true;
                }
            }
        }
        return false;
    }

    public static ArrayList b(Context context) {
        ArrayList arrayList = new ArrayList();
        String string = Settings.Secure.getString(context.getContentResolver(), "enabled_accessibility_services");
        if (!TextUtils.isEmpty(string)) {
            TextUtils.SimpleStringSplitter simpleStringSplitter = new TextUtils.SimpleStringSplitter(':');
            simpleStringSplitter.setString(string);
            while (simpleStringSplitter.hasNext()) {
                String next = simpleStringSplitter.next();
                if (!TextUtils.isEmpty(next)) {
                    String[] strArrSplit = next.split("/");
                    if (strArrSplit.length == 2 && !TextUtils.isEmpty(strArrSplit[0]) && !TextUtils.isEmpty(strArrSplit[1])) {
                        arrayList.add(new ComponentName(strArrSplit[0], strArrSplit[1]));
                    }
                }
            }
        }
        return arrayList;
    }

    public static String a(Context context) {
        StringBuilder sb = new StringBuilder();
        try {
            HashSet hashSet = new HashSet();
            AccessibilityManager accessibilityManager = (AccessibilityManager) context.getSystemService("accessibility");
            sb.append(accessibilityManager.isEnabled() ? 1 : 0);
            sb.append(",");
            sb.append(accessibilityManager.isTouchExplorationEnabled() ? 1 : 0);
            sb.append(",");
            AtomicBoolean atomicBoolean = new AtomicBoolean(true);
            for (AccessibilityServiceInfo accessibilityServiceInfo : accessibilityManager.getEnabledAccessibilityServiceList(-1)) {
                if (!atomicBoolean.compareAndSet(true, false)) {
                    sb.append(com.alipay.sdk.m.y.l.b);
                }
                sb.append(Integer.toHexString(accessibilityServiceInfo.eventTypes));
                sb.append(":");
                sb.append(Integer.toHexString(accessibilityServiceInfo.feedbackType));
                sb.append(":");
                sb.append(Integer.toHexString(accessibilityServiceInfo.flags));
                sb.append(":");
                sb.append(Integer.toHexString(accessibilityServiceInfo.getCapabilities()));
                sb.append(":");
                sb.append(accessibilityServiceInfo.getId());
                hashSet.add(accessibilityServiceInfo.getId());
            }
            sb.append(",");
            sb.append(Settings.Secure.getInt(context.getContentResolver(), "accessibility_enabled", -1));
            sb.append(",");
            atomicBoolean.set(true);
            ArrayList arrayListB = b(context);
            int size = arrayListB.size();
            int i = 0;
            while (i < size) {
                Object obj = arrayListB.get(i);
                i++;
                ComponentName componentName = (ComponentName) obj;
                if (!hashSet.contains(componentName.flattenToShortString()) && !hashSet.contains(componentName.flattenToString())) {
                    if (!atomicBoolean.compareAndSet(true, false)) {
                        sb.append(com.alipay.sdk.m.y.l.b);
                    }
                    sb.append(componentName.flattenToShortString());
                }
            }
            sb.append(",");
            atomicBoolean.set(true);
            for (AccessibilityServiceInfo accessibilityServiceInfo2 : accessibilityManager.getInstalledAccessibilityServiceList()) {
                if (!hashSet.contains(accessibilityServiceInfo2.getId()) && !a(accessibilityServiceInfo2)) {
                    if (!atomicBoolean.compareAndSet(true, false)) {
                        sb.append(com.alipay.sdk.m.y.l.b);
                    }
                    sb.append(Integer.toHexString(accessibilityServiceInfo2.eventTypes));
                    sb.append(":");
                    sb.append(Integer.toHexString(accessibilityServiceInfo2.feedbackType));
                    sb.append(":");
                    sb.append(Integer.toHexString(accessibilityServiceInfo2.flags));
                    sb.append(":");
                    sb.append(Integer.toHexString(accessibilityServiceInfo2.getCapabilities()));
                    sb.append(":");
                    sb.append(accessibilityServiceInfo2.getId());
                    accessibilityServiceInfo2.getId();
                }
            }
            return sb.toString();
        } catch (Throwable unused) {
            return "exp";
        }
    }
}
