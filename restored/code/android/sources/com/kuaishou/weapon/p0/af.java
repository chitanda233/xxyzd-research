package com.kuaishou.weapon.p0;

import android.os.Process;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.InputStreamReader;
import java.util.HashSet;

/* JADX INFO: loaded from: classes3.dex */
public class af {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String[] f2626a = {"/sbin/.magisk/", "/sbin/.core/mirror", "/sbin/.core/img", "/sbin/.core/db-0/magisk.db"};

    public int a() {
        File file = new File(String.format("/proc/%d/mounts", Integer.valueOf(Process.myPid())));
        try {
            HashSet hashSet = new HashSet();
            FileInputStream fileInputStream = new FileInputStream(file);
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(fileInputStream));
            while (true) {
                String line = bufferedReader.readLine();
                if (line != null) {
                    for (String str : this.f2626a) {
                        if (line.contains(str)) {
                            hashSet.add(line);
                            break;
                        }
                    }
                } else {
                    bufferedReader.close();
                    fileInputStream.close();
                    return hashSet.size();
                }
            }
        } catch (Exception unused) {
            return 0;
        }
    }
}
