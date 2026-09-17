package com.kwad.library.b.a;

import android.app.Activity;
import dalvik.system.BaseDexClassLoader;
import dalvik.system.PathClassLoader;
import java.io.InputStream;
import java.net.URL;
import java.util.Enumeration;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends PathClassLoader {
    private static final List<ClassLoader> aDL = new CopyOnWriteArrayList();
    private final BaseDexClassLoader aDK;

    public a(BaseDexClassLoader baseDexClassLoader) {
        super("", baseDexClassLoader);
        this.aDK = baseDexClassLoader;
    }

    @Override // dalvik.system.BaseDexClassLoader, java.lang.ClassLoader
    protected final Class<?> findClass(String str) throws ClassNotFoundException {
        Class<?> cls = null;
        try {
            Class<?> clsLoadClass = this.aDK.loadClass(str);
            if (Activity.class.isAssignableFrom(clsLoadClass)) {
                return clsLoadClass;
            }
            th = null;
            cls = clsLoadClass;
            if (cls != null) {
                return cls;
            }
            Iterator<ClassLoader> it = aDL.iterator();
            while (it.hasNext()) {
                Class<?> clsLoadClass2 = it.next().loadClass(str);
                if (clsLoadClass2 != null) {
                    return clsLoadClass2;
                }
            }
            if (th instanceof ClassNotFoundException) {
                throw th;
            }
            throw new ClassNotFoundException(str, th);
        } catch (Throwable th) {
            th = th;
        }
    }

    @Override // java.lang.ClassLoader
    public final InputStream getResourceAsStream(String str) {
        return this.aDK.getResourceAsStream(str);
    }

    @Override // java.lang.ClassLoader
    public final Enumeration<URL> getResources(String str) {
        return this.aDK.getResources(str);
    }

    @Override // java.lang.ClassLoader
    public final URL getResource(String str) {
        return this.aDK.getResource(str);
    }

    @Override // java.lang.ClassLoader
    public final Class<?> loadClass(String str) {
        return findClass(str);
    }

    @Override // dalvik.system.BaseDexClassLoader, java.lang.ClassLoader
    public final String findLibrary(String str) {
        return this.aDK.findLibrary(str);
    }

    @Override // dalvik.system.BaseDexClassLoader
    public final String toString() {
        return this.aDK.toString();
    }
}
