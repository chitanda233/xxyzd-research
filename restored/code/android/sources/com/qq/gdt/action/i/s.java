package com.qq.gdt.action.i;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class s {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3085a = com.qq.gdt.action.d.a().g().getFilesDir() + File.separator + "gdtDir" + File.separator + "gdt_user_message_v5";

    public static synchronized com.qq.gdt.action.multioprocess.b a() {
        ObjectInputStream objectInputStream;
        try {
            com.qq.gdt.action.multioprocess.b bVar = null;
            if (!com.qq.gdt.action.multioprocess.a.a().c()) {
                o.a("UserMessage get() no fill，no get info", new Object[0]);
                return null;
            }
            o.a("SerializableUtils get userinfo", new Object[0]);
            try {
                objectInputStream = new ObjectInputStream(new FileInputStream(f3085a));
                try {
                    com.qq.gdt.action.multioprocess.b bVar2 = (com.qq.gdt.action.multioprocess.b) objectInputStream.readObject();
                    try {
                        objectInputStream.close();
                    } catch (Throwable th) {
                        o.a("SerializableUtils get close ex = " + th, new Object[0]);
                    }
                    bVar = bVar2;
                } catch (Throwable th2) {
                    th = th2;
                    try {
                        o.a("SerializableUtils get ex = " + th, new Object[0]);
                        com.qq.gdt.action.g.a.a(3404);
                        try {
                            objectInputStream.close();
                        } catch (Throwable th3) {
                            o.a("SerializableUtils get close ex = " + th3, new Object[0]);
                        }
                    } catch (Throwable th4) {
                        try {
                            objectInputStream.close();
                        } catch (Throwable th5) {
                            o.a("SerializableUtils get close ex = " + th5, new Object[0]);
                        }
                        throw th4;
                    }
                }
            } catch (Throwable th6) {
                th = th6;
                objectInputStream = null;
            }
            return bVar;
        } catch (Throwable th7) {
            throw th7;
        }
    }

    public static synchronized void a(final com.qq.gdt.action.multioprocess.b bVar) {
        if (com.qq.gdt.action.multioprocess.a.a().c()) {
            j.a().b().execute(new Runnable() { // from class: com.qq.gdt.action.i.s.1
                @Override // java.lang.Runnable
                public void run() {
                    o.a("cp信息开始存储 SerializableUtils save, userMessage = " + bVar, new Object[0]);
                    long jCurrentTimeMillis = System.currentTimeMillis();
                    ObjectOutputStream objectOutputStream = null;
                    try {
                        File file = new File(s.f3085a);
                        if (file.exists()) {
                            file.delete();
                        }
                        if (!file.getParentFile().exists()) {
                            o.a("creating parent directory...", new Object[0]);
                            if (!file.getParentFile().mkdirs()) {
                                throw new Exception("created parent directory failed.");
                            }
                        }
                        file.createNewFile();
                        ObjectOutputStream objectOutputStream2 = new ObjectOutputStream(new FileOutputStream(s.f3085a));
                        try {
                            objectOutputStream2.writeObject(bVar);
                            long jCurrentTimeMillis2 = System.currentTimeMillis() - jCurrentTimeMillis;
                            new JSONObject().put("ipcSaveFileTimeSuccess", jCurrentTimeMillis2);
                            o.a("cp save file successTime cost = " + jCurrentTimeMillis2, new Object[0]);
                            try {
                                objectOutputStream2.close();
                            } catch (Throwable th) {
                                o.a("SerializableUtils save fileclose ex = " + th, new Object[0]);
                            }
                        } catch (Throwable th2) {
                            th = th2;
                            objectOutputStream = objectOutputStream2;
                            try {
                                o.a("SerializableUtils cp save file  save ex  = " + th, new Object[0]);
                                com.qq.gdt.action.g.a.a(3306, bVar);
                                try {
                                    objectOutputStream.close();
                                } catch (Throwable th3) {
                                    o.a("SerializableUtils save fileclose ex = " + th3, new Object[0]);
                                }
                            } catch (Throwable th4) {
                                try {
                                    objectOutputStream.close();
                                } catch (Throwable th5) {
                                    o.a("SerializableUtils save fileclose ex = " + th5, new Object[0]);
                                }
                                throw th4;
                            }
                        }
                    } catch (Throwable th6) {
                        th = th6;
                    }
                    long jCurrentTimeMillis3 = System.currentTimeMillis() - jCurrentTimeMillis;
                    try {
                        new JSONObject().put("ipcSaveFileTimeEnd", jCurrentTimeMillis3);
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                    o.a("save file endTime cost = " + jCurrentTimeMillis3 + " userMessage = " + bVar, new Object[0]);
                }
            });
        } else {
            o.a("UserMessage save() 未开启补齐信息，不进行文件保存信息", new Object[0]);
        }
    }

    public static synchronized void a(final com.qq.gdt.action.multioprocess.c cVar) {
        if (com.qq.gdt.action.multioprocess.a.a().c()) {
            j.a().b().execute(new Runnable() { // from class: com.qq.gdt.action.i.s.2
                @Override // java.lang.Runnable
                public void run() {
                    cVar.a(s.a());
                }
            });
        } else {
            o.a("UserMessage getAsync() no fill，no get info", new Object[0]);
            cVar.a(null);
        }
    }
}
