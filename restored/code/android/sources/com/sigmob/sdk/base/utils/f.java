package com.sigmob.sdk.base.utils;

import java.util.Collection;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class f {
    public static boolean a(int position, int size) {
        return position >= 0 && position < size;
    }

    public static boolean a(int position, Collection<?> list) {
        if (a(list)) {
            return false;
        }
        return a(position, list.size());
    }

    public static boolean a(int position, Map<?, ?> hashMap) {
        if (a(hashMap)) {
            return false;
        }
        return a(position, hashMap.size());
    }

    public static boolean a(Collection<?> list) {
        return list == null || list.isEmpty();
    }

    public static boolean a(Map<?, ?> hashMap) {
        return hashMap == null || hashMap.isEmpty();
    }

    public static boolean a(Object[] array) {
        return array == null || array.length == 0;
    }

    public static boolean b(Collection<?> list) {
        return !a(list);
    }

    public static boolean b(Map<?, ?> hashMap) {
        return !a(hashMap);
    }

    public static boolean b(Object[] array) {
        return !a(array);
    }
}
