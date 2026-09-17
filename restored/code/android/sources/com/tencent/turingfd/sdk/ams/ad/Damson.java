package com.tencent.turingfd.sdk.ams.ad;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Damson {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final ArrayList f3844a = new ArrayList();

    public static synchronized ArrayList a(ITuringPkgProvider iTuringPkgProvider) {
        List<String> pkgs;
        ArrayList arrayList = f3844a;
        if (!arrayList.isEmpty() || iTuringPkgProvider == null || (pkgs = iTuringPkgProvider.getPkgs()) == null || pkgs.isEmpty()) {
            return arrayList;
        }
        arrayList.addAll(pkgs);
        return arrayList;
    }

    public static String a(HashSet hashSet) {
        StringBuilder sb = new StringBuilder();
        try {
            Iterator it = hashSet.iterator();
            while (it.hasNext()) {
                String str = (String) it.next();
                if (sb.length() > 0) {
                    sb.append("|");
                }
                sb.append(str);
            }
        } catch (Throwable unused) {
        }
        return sb.toString();
    }
}
